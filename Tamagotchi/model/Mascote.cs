using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Model
{
    public class Mascote : Pokemon
    {
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
            if ((Humor + 1) <= 10)
            {
                Humor++;
            }
            if ((Energia + 1) <= 10)
            {
                Energia++;
            }
            if ((Alimentacao + 2) <= 10)
            {
                Alimentacao += 2;
            }
        }

        public void BrincarMascote()
        {
            if ((Humor + 2) <= 10)
            {
                Humor += 2;
            }
            if ((Energia - 2) > 0)
            {
                Energia -= 2;
            }
            if ((Alimentacao - 1) > 0)
            {
                Alimentacao--;
            }
        }

        public void DormirMascote()
        {
            if ((Humor - 2) > 0)
            {
                Humor -= 2;
            }
            if ((Energia + 2) <= 10)
            {
                Energia += 2;
            }
            if ((Alimentacao - 1) > 0)
            {
                Alimentacao--;
            }
        }

    }
}