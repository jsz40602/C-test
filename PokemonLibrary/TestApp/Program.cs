using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace TestApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon()
            {
                Name = "Bulbasaur",
                NationalNo = "001",
                Type = ["Grass", "Poison"],
                Species = "Seed",
                Height = 0.71,
                Weight = 6.9
            };
        }
    }
}