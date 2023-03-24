using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Classe que representa o retorno da requisição à URL https://pokeapi.co/api/v2/pokemon/

namespace Tamagotchi.Model
{
    public class Informacoes
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<Results> results { get; set; }

        public bool ResultsContains(string especieBuscada)
        {
            foreach (var result in results)
            {
                if (especieBuscada.ToUpper() == result.name.ToUpper())
                    return true;
            }
            return false;
        }
    }
}
