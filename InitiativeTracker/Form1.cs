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
            DataHandling.NewRound();
            lbl_RoundCount.Text = DataHandling.Round.ToString();
            lbl_Turn.Text = $"It's {DataHandling.CurrentPokemon.Name}'s Turn!";
        }
    }
}
