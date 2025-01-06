using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace InitiativeTracker
{
    public partial class FrontEnd : Form
    {
        public FrontEnd()
        {
            InitializeComponent();
        }

        private void btn_AddPokemon_Click(object sender, EventArgs e)
        {
            InputColorsReset();

            bool areFieldsValid = ValidateInputFields();
            if (!areFieldsValid) return;

            bool isInitiativeValid = int.TryParse(txtbx_InitiativeInput.Text, out int initiative);

            if (!isInitiativeValid || initiative < 1)
            {
                txtbx_InitiativeInput.BackColor = Color.Salmon;
                return;
            }

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


            txtbx_DexInput.Text = "";
            txtbx_InitiativeInput.Text = "";
        }

        private bool ValidateInputFields()
        {
            if (String.IsNullOrEmpty(txtbx_InitiativeInput.Text) && String.IsNullOrEmpty(txtbx_Pokéinput.Text))
            {
                txtbx_InitiativeInput.BackColor = Color.Salmon;
                txtbx_Pokéinput.BackColor = Color.Salmon;
                return false;
            }

            if (String.IsNullOrEmpty(txtbx_InitiativeInput.Text))
            {
                txtbx_InitiativeInput.BackColor = Color.Salmon;
                return false;
            }

            if (String.IsNullOrEmpty(txtbx_Pokéinput.Text))
            {
                txtbx_Pokéinput.BackColor = Color.Salmon;
                return false;
            }

            return true;
        }

        private void InputColorsReset()
        {
            txtbx_InitiativeInput.BackColor = SystemColors.Window;
            txtbx_Pokéinput.BackColor = SystemColors.Window;
            txtbx_DexInput.BackColor = SystemColors.Window;
        }

        private void UpdateTracker(bool resort)
        {
            bool trickRoom = GetTrickRoomStatus();

            dgv_Tracker.Rows.Clear();
            if (resort && !trickRoom)
            {
                DataHandling.ActivePokemon = (from pokemon in DataHandling.ActivePokemon
                                              orderby pokemon.Initiative descending, pokemon.Dexterity descending
                                              select pokemon).ToList();
            }

            if (resort && trickRoom)
            {
                DataHandling.ActivePokemon = (from pokemon in DataHandling.ActivePokemon
                                              orderby pokemon.Initiative, pokemon.Dexterity
                                              select pokemon).ToList();
            }

            foreach (Pokemon pokemon in DataHandling.ActivePokemon)
            {
                string evaded = pokemon.Evaded ? "YES" : "no";
                string clashed = pokemon.Clashed ? "YES" : "no";

                dgv_Tracker.Rows.Add(pokemon.Name, pokemon.Initiative, pokemon.SuccessesNeeded, pokemon.Dexterity, evaded, clashed);

            }

            if (DataHandling.CurrentPokemon != null) HighlightCurrentMon();
            ColourClashedAndEvaded();
        }

        /*        private void UpdatePokemonClashedEvaded()
                {
                    foreach (DataGridViewRow row in dgv_Tracker.Rows)
                    {
                        Pokemon? pokemon = DataHandling.GetPokemonByName(row.Cells[0].Value.ToString());
                        if (pokemon != null)
                        {
                            pokemon.Evaded = (bool)row.Cells[4].Value;
                            pokemon.Clashed = (bool)row.Cells[5].Value;
                        }
                    }
                }*/

        private bool GetTrickRoomStatus()
        {
            if (chkbx_TrickRoom.Checked) return true;
            else return false;
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
            InputColorsReset();

            bool areFieldsValid = ValidateInputFields();
            if (!areFieldsValid) return;

            Pokemon? pokemonToUpdate = DataHandling.GetPokemonByName(txtbx_Pokéinput.Text);
            if (pokemonToUpdate == null)
            {
                txtbx_Pokéinput.BackColor = Color.Salmon;
                return;
            }

            bool isInitiativeValid = int.TryParse(txtbx_InitiativeInput.Text, out int initiative);
            if (!isInitiativeValid || initiative < 1)
            {
                txtbx_InitiativeInput.BackColor = Color.Salmon;
                return;
            }

            bool isDexterityValid = int.TryParse(txtbx_DexInput.Text, out int dexterity);

            if (!isDexterityValid && String.IsNullOrEmpty(txtbx_DexInput.Text))
            {
                DataHandling.UpdatePokemon(pokemonToUpdate, initiative);
            }
            else if (!isDexterityValid)
            {
                txtbx_DexInput.BackColor = Color.Salmon;
                DataHandling.UpdatePokemon(pokemonToUpdate, initiative);
            }
            else DataHandling.UpdatePokemon(pokemonToUpdate, initiative, dexterity);

            UpdateTracker(true);
        }

        private void CheckTrickRoomChanged(object sender, EventArgs e)
        {
            DataHandling.ActivePokemon.Reverse();
            UpdateTracker(false);
        }

        private void dgv_Tracker_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow row = dgv_Tracker.Rows[e.RowIndex];

            if (row.Cells[0].Value != null && row.Cells[1].Value != null)
            {
                string? pokemon = row.Cells[0].Value.ToString();
                if (pokemon != null) txtbx_Pokéinput.Text = row.Cells[0].Value.ToString();

                string? initiative = row.Cells[1].Value.ToString();
                if (initiative != null) txtbx_InitiativeInput.Text = row.Cells[1].Value.ToString();

                if (row.Cells[3].Value != null)
                {
                    string? dexterity = row.Cells[3].Value.ToString();
                    if (dexterity != null) txtbx_DexInput.Text = row.Cells[3].Value.ToString();
                }
                else txtbx_DexInput.Text = "";
            }

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
            foreach (DataGridViewRow pokemon in dgv_Tracker.Rows)
            {
                if (pokemon.Cells[0].Value.ToString() == DataHandling.CurrentPokemon.Name)
                {
                    pokemon.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else pokemon.DefaultCellStyle.BackColor = Color.Gray;
            }
        }

        private void ColourClashedAndEvaded()
        {
            foreach (DataGridViewRow pokemon in dgv_Tracker.Rows)
            {
                if (pokemon.Cells[4].Value.ToString() == "no")
                {
                    pokemon.Cells[4].Style.BackColor = Color.LightGray;
                }
                else pokemon.Cells[4].Style.BackColor = Color.IndianRed;

                if (pokemon.Cells[5].Value.ToString() == "no")
                {
                    pokemon.Cells[5].Style.BackColor = Color.LightGray;
                }
                else pokemon.Cells[5].Style.BackColor = Color.IndianRed;
            }
        }

        private void btn_FaintClick(object sender, EventArgs e)
        {
            Pokemon? faintedMon = DataHandling.GetPokemonByName(txtbx_Pokéinput.Text);
            if (faintedMon == null) return;

            DataHandling.TryFaintPokemon(faintedMon);
            UpdateTracker(false);
            if (DataHandling.Round > 0) UpdateTurnLabel();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            DataHandling.Reset();
            UpdateTracker(false);
            lbl_RoundCount.Text = "0";
            lbl_Turn.Text = "Whose Turn Is It?";
            btn_NewRound.Text = "Start!";

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

        private void btn_Help_Click(object sender, EventArgs e)
        {
            string message = """
                            The "Add Pokemon" button adds a new Pokémon to the initative. Pokemon must have a name and Initiative, but dex is optional.
                            When you are ready to start the fight, press "Start!" to begin!

                            You can update pokemon Initative and Dex at the end of the round by clicking each Pokémon, putting in the new numbers, and hitting Update Pokemon.
                            Then click New Round to start the next round!

                            Hit the Use Move button to increase the Successes Needed of the selected Pokémon by 1 (or the Undo button next to it to reduce the Successes Needed).

                            Hit Clash to change the Clashed status of the selected Pokémon and increase its needed successes (or the undo button next to it to do the opposite).
                            You can use the Evade buttons in the same way.

                            You can see how many Successes any given Pokémon needs to succeed in the "SN" column of the tracker.

                            You can move any pokemon up or down, update their details, or faint them, by double clicking their name in the tracker and hitting the relevant button.

                            You can check the "Trick Room" box to reverse the turn order.
                            """;
            MessageBox.Show(message, "Help");
        }

        private void btn_Bulbapedia_Click(object sender, EventArgs e)
        {
            string linkStart = "https://bulbapedia.bulbagarden.net/w/index.php?title=Special%3ASearch&search=";
            string fullLink = linkStart + txtbx_Pokéinput.Text + "&fulltext=1";

            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = fullLink,
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void btn_pdb_Click(object sender, EventArgs e)
        {
            string linkStart = "https://pokemondb.net/pokedex/";
            string fullLink = linkStart + txtbx_Pokéinput.Text;

            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = fullLink,
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void btn_MoveUndo_Click(object sender, EventArgs e)
        {
            Pokemon? undoingMon = DataHandling.GetPokemonByName(txtbx_Pokéinput.Text);
            if (undoingMon == null) return;

            if (undoingMon.SuccessesNeeded == 0) return;

            undoingMon.SuccessesNeeded--;
            UpdateTracker(false);
        }

        private void btn_Clash_Click(object sender, EventArgs e)
        {
            Pokemon? clashingMon = DataHandling.GetPokemonByName(txtbx_Pokéinput.Text);
            if (clashingMon == null) return;

            if (clashingMon.Clashed) return;

            clashingMon.Clashed = true;
            clashingMon.SuccessesNeeded++;
            UpdateTracker(false);
        }

        private void btn_ClashUndo_Click(object sender, EventArgs e)
        {
            Pokemon? unclashingMon = DataHandling.GetPokemonByName(txtbx_Pokéinput.Text);
            if (unclashingMon == null) return;

            if (!unclashingMon.Clashed) return;

            unclashingMon.Clashed = false;
            unclashingMon.SuccessesNeeded--;
            UpdateTracker(false);
        }

        private void btn_Evade_Click(object sender, EventArgs e)
        {
            Pokemon? evadingMon = DataHandling.GetPokemonByName(txtbx_Pokéinput.Text);
            if (evadingMon == null) return;

            if (evadingMon.Evaded) return;

            evadingMon.Evaded = true;
            evadingMon.SuccessesNeeded++;
            UpdateTracker(false);
        }

        private void btn_EvadeUndo_Click(object sender, EventArgs e)
        {
            Pokemon? evadingMon = DataHandling.GetPokemonByName(txtbx_Pokéinput.Text);
            if (evadingMon == null) return;

            if (!evadingMon.Evaded) return;

            evadingMon.Evaded = false;
            evadingMon.SuccessesNeeded--;
            UpdateTracker(false);
        }
    }
}
