using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Classe que representa um pokemon retornado pela url https://pokeapi.co/api/v2/pokemon/{especie}

namespace Tamagotchi.Model
{
    public class Pokemon
    {
        public List<Abilities> abilities { get; set; }
        public string name { get; set; }
        public double height { get; set; }
        public double weight { get; set; }

}
}
