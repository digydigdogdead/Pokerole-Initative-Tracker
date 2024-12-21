namespace InitiativeTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddPokemon_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbx_InitiativeInput.Text) || String.IsNullOrEmpty(txtbx_Pokéinput.Text))
            {
                return;
            }

            bool isInitiativeValid = int.TryParse(txtbx_InitiativeInput.Text, out int initiative);

            if (!isInitiativeValid ||
                initiative < 1)
            { return; }

            Pokemon newPokemon = new(txtbx_Pokéinput.Text, initiative);
            DataHandling.ActivePokemon.Add(newPokemon);
            UpdateTracker();
        }

        private void UpdateTracker()
        {
            lstvw_InitTracker.Items.Clear();
            DataHandling.ActivePokemon = (from pokemon in DataHandling.ActivePokemon
                                          orderby pokemon.Initiative descending
                                          select pokemon).ToList();

            foreach (Pokemon pokemon in DataHandling.ActivePokemon)
            {
                ListViewItem item = new ListViewItem(pokemon.Name);
                item.SubItems.Add(pokemon.Initiative.ToString());
                item.SubItems.Add(pokemon.SuccessesNeeded.ToString());

                lstvw_InitTracker.Items.Add(item);

            }
        }

        private void btn_NewRound_Click(object sender, EventArgs e)
        {
            if (DataHandling.ActivePokemon.Count == 0) return;
            DataHandling.NewRound();
            UpdateTracker();
            lbl_RoundCount.Text = DataHandling.Round.ToString();
            lbl_Turn.Text = $"It's {DataHandling.CurrentPokemon.Name}'s Turn!";
        }

        private void btn_UseAction_Click(object sender, EventArgs e)
        {
            DataHandling.UseAction();
            UpdateTracker();
        }

        private void btn_UpdatePokemon_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbx_Pokéinput.Text) || String.IsNullOrEmpty(txtbx_Pokéinput.Text)) return;

            Pokemon? pokemonToUpdate = DataHandling.GetPokemonByName(txtbx_Pokéinput.Text);
            if (pokemonToUpdate == null) return;

            bool isInitiativeValid = int.TryParse(txtbx_InitiativeInput.Text, out int initiative);
            if (!isInitiativeValid || initiative < 1) return;

            DataHandling.UpdatePokemon(pokemonToUpdate, initiative);
            UpdateTracker();
        }

        private void lstvw_InitTracker_SelectedItemChanged(object sender, EventArgs e)
        {
            txtbx_Pokéinput.Text = lstvw_InitTracker.SelectedItems[0].Text;
            lstvw_InitTracker.SelectedItems[0].Focused = false;
            txtbx_Pokéinput.Focus();


        }
    }
}
