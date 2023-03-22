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
        public int Alimentacao { get; set; }
        public int Humor { get; set; }
        public int Energia { get; set; }
        public DateTime DataNascimento { get; set; }

        public Mascote() 
        {
            Random valorAleatorio = new();
            Alimentacao = valorAleatorio.Next(1, 10);
            Humor = valorAleatorio.Next(1, 10);
            Energia = valorAleatorio.Next(1, 10);
            DataNascimento = DateTime.Now;

        }

        public void AlimentarMascote()
        {
            Alimentacao += 2;
            Humor++;
            Energia++;
        }

        public void BrincarMascote()
        {
            Humor += 2;
            Energia -= 2;
            Alimentacao--;
        }

        public void DormirMascote()
        {
            Energia += 2;
            Alimentacao--;
        }

}
}
