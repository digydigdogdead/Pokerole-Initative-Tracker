using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiativeTracker
{
    internal class Pokemon(string name, int initiative)
    {
        public String Name { get; set; } = name;
        public int Initiative { get; set; } = initiative;
        public int SuccessesNeeded { get; set; } = 1;

        public bool IsAlive { get; set; } = true;

        public void UseAction()
        {
            SuccessesNeeded++;
        }

        public void Faint()
        {
            IsAlive = false;
        }
        
    }
}
