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

        public static int Round {  get; set; } = 0;

        public static Pokemon? TrackedPokemon { get; set; }
        public static void NewRound()
        {
            Round++;

            foreach (var pokemon in ActivePokemon)
            {
                pokemon.SuccessesNeeded = 1;
            }
        }

        public static void NextTurn()
        {

        }

        public static void GetNewPokemon()
        {

        }

        public static void FaintPokemon()
        {
            Pokemon pokemonToFaint = TrackedPokemon;
            NextTurn();
            ActivePokemon.Remove(pokemonToFaint);
        }
    }
}
