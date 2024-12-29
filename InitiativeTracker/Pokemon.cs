using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiativeTracker
{
    internal class Pokemon(string name, int initiative, int? dexterity = null)
    {
        public String Name { get; set; } = name;
        public int Initiative { get; set; } = initiative;
        public int SuccessesNeeded { get; set; } = 1;
        public int? Dexterity { get; set; } = dexterity;
        public bool Evaded { get; set; } = false;
        public bool Clashed { get; set; } = false;


        public void UseAction()
        {
            SuccessesNeeded++;
        }
        
    }
}
