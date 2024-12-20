using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiativeTracker
{
    internal static class FrontEnd
    {
        public static List<Pokemon> ActivePokemon = new List<Pokemon>();

        public static int Round {  get; set; }

        public static void NewRound()
        {
            Round++;

            foreach (var pokemon in ActivePokemon)
            {
                pokemon.SuccessesNeeded = 1;
            }
        }

        public static void GetNewPokemon()
        {

        }
    }
}
