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
            FrontEnd.ActivePokemon.Add(newPokemon);
            UpdateTracker();
        }

        private void UpdateTracker()
        {
            lstvw_InitTracker.Items.Clear();
            FrontEnd.ActivePokemon = (from pokemon in FrontEnd.ActivePokemon
                                      orderby pokemon.Initiative descending
                                      select pokemon).ToList();

            foreach (Pokemon pokemon in FrontEnd.ActivePokemon)
            {
                ListViewItem item = new ListViewItem(pokemon.Name);
                item.SubItems.Add(pokemon.Initiative.ToString());
                item.SubItems.Add(pokemon.SuccessesNeeded.ToString());
                
                lstvw_InitTracker.Items.Add(item);
                
            }
        }
    }
}
