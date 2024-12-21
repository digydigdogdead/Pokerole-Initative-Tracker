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

            bool isDexterityValid = int.TryParse(txtbx_DexInput.Text, out int dexterity);

            if (!isDexterityValid)
            {
                Pokemon newPokemon = new(txtbx_Pokéinput.Text, initiative);
                DataHandling.ActivePokemon.Add(newPokemon);
            }
            else
            {
                Pokemon newPokemon = new(txtbx_Pokéinput.Text, initiative, dexterity);
                DataHandling.ActivePokemon.Add(newPokemon);
            }
            UpdateTracker(true);
        }

        private void UpdateTracker(bool resort)
        {
            lstvw_InitTracker.Items.Clear();
            if (resort)
            {
                DataHandling.ActivePokemon = (from pokemon in DataHandling.ActivePokemon
                                              orderby pokemon.Initiative descending, pokemon.Dexterity descending
                                              select pokemon).ToList();
            }
            foreach (Pokemon pokemon in DataHandling.ActivePokemon)
            {
                ListViewItem item = new ListViewItem(pokemon.Name);
                item.SubItems.Add(pokemon.Initiative.ToString());
                item.SubItems.Add(pokemon.SuccessesNeeded.ToString());
                item.SubItems.Add(pokemon.Dexterity.ToString());

                lstvw_InitTracker.Items.Add(item);

            }

            if (DataHandling.CurrentPokemon != null) HighlightCurrentMon();
        }

        private void btn_NewRound_Click(object sender, EventArgs e)
        {
            if (DataHandling.ActivePokemon.Count == 0) return;

            DataHandling.NewRound();
            UpdateTracker(true);
            if (DataHandling.Round > 0) btn_NewRound.Text = "New Round";
            lbl_RoundCount.Text = DataHandling.Round.ToString();
            txtbx_Pokéinput.Text = DataHandling.CurrentPokemon.Name;
            UpdateTurnLabel();
            HighlightCurrentMon();
        }

        private void btn_UseAction_Click(object sender, EventArgs e)
        {
            Pokemon? selectedMon = DataHandling.GetPokemonByName(txtbx_Pokéinput.Text);
            if (selectedMon == null) return;
            DataHandling.UseAction(selectedMon);
            UpdateTracker(false);
        }

        private void btn_UpdatePokemon_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbx_Pokéinput.Text) || String.IsNullOrEmpty(txtbx_Pokéinput.Text)) return;

            Pokemon? pokemonToUpdate = DataHandling.GetPokemonByName(txtbx_Pokéinput.Text);
            if (pokemonToUpdate == null) return;

            bool isInitiativeValid = int.TryParse(txtbx_InitiativeInput.Text, out int initiative);
            if (!isInitiativeValid || initiative < 1) return;

            bool isDexterityValid = int.TryParse(txtbx_DexInput.Text, out int dexterity);

            if (!isDexterityValid) DataHandling.UpdatePokemon(pokemonToUpdate, initiative);
            else DataHandling.UpdatePokemon(pokemonToUpdate, initiative, dexterity);

            UpdateTracker(true);
        }

        private void lstvw_InitTracker_SelectedItemChanged(object sender, EventArgs e)
        {
            txtbx_Pokéinput.Text = lstvw_InitTracker.SelectedItems[0].Text;
            lstvw_InitTracker.SelectedItems[0].Focused = false;
            txtbx_Pokéinput.Focus();


        }

        private void btn_NextTurn_Click(object sender, EventArgs e)
        {
            if (DataHandling.Round == 0) return;

            bool result = DataHandling.TryNextTurn();

            if (result)
            {
                UpdateTurnLabel();
                HighlightCurrentMon();
            }

            txtbx_Pokéinput.Text = DataHandling.CurrentPokemon.Name;
        }

        private void UpdateTurnLabel()
        {
            lbl_Turn.Text = $"It's {DataHandling.CurrentPokemon.Name}'s Turn!";
        }
        private void HighlightCurrentMon()
        {
            foreach (ListViewItem pokemon in lstvw_InitTracker.Items)
            {
                if (pokemon.Text == DataHandling.CurrentPokemon.Name)
                {
                    pokemon.BackColor = Color.LightGreen;
                }
                else pokemon.BackColor = Color.Gray;
            }
        }

        private void btn_FaintClick(object sender, EventArgs e)
        {
            Pokemon? faintedMon = DataHandling.GetPokemonByName(txtbx_Pokéinput.Text);
            if (faintedMon == null) return;

            DataHandling.TryFaintPokemon(faintedMon);
            UpdateTracker(false);
            UpdateTurnLabel();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            DataHandling.Reset();
            UpdateTracker(false);
            lbl_RoundCount.Text = "0";
            lbl_Turn.Text = "Who's Turn Is It?";

        }

        private void btn_MoveUp_Click(object sender, EventArgs e)
        {
            Pokemon? movingMon = DataHandling.GetPokemonByName(txtbx_Pokéinput.Text);
            if (movingMon == null) return;

            DataHandling.MoveUp(movingMon);
            UpdateTracker(false);
        }

        private void btn_MoveDown_Click(object sender, EventArgs e)
        {
            Pokemon? movingMon = DataHandling.GetPokemonByName(txtbx_Pokéinput.Text);
            if (movingMon == null) return;

            DataHandling.MoveDown(movingMon);
            UpdateTracker(false);
        }
    }
}
