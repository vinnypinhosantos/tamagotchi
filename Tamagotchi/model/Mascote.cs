using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Model
{
    public class Mascote
    {
        public List<Abilities> abilities { get; set; }
        public string name { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public Mascote() 
        {

        }
        public override string ToString()
        {
            string mascote = 
                "Nome: " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower()) + "\n" + 
                "Altura: " + height + "\n" + 
                "Peso: " + weight + "\n" + 
                "Habilidades:" + "\n";

            foreach (Abilities ability in abilities)
            {
                mascote += ability.ToString();
                mascote += "\n";
            }
            return mascote;
        }


}
}
