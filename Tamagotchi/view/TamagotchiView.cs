using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tamagotchi.Model;

namespace Tamagotchi.View
{
    public class TamagotchiView
    {
        public string nameJogador { get; set; }
        public string especieMascote { get; set; }
        public void BoasVindas()
        {
            Console.WriteLine(@" 
     #######                                                                    
        #       ##    #    #    ##     ####    ####   #####   ####   #    #  # 
        #      #  #   ##  ##   #  #   #    #  #    #    #    #    #  #    #  # 
        #     #    #  # ## #  #    #  #       #    #    #    #       ######  # 
        #     ######  #    #  ######  #  ###  #    #    #    #       #    #  # 
        #     #    #  #    #  #    #  #    #  #    #    #    #    #  #    #  # 
        #     #    #  #    #  #    #   ####    ####     #     ####   #    #  #");
            Console.WriteLine("\n\nQual é o seu nome?");
            nameJogador = Console.ReadLine().ToUpper();
        }
        public void MenuInicial()
        {
            Console.WriteLine("\n\n--------------------------- MENU ---------------------------");
            Console.WriteLine($"{nameJogador} Você deseja:");
            Console.WriteLine("1 - Adotar um mascote virtual");
            Console.WriteLine("2 - Ver seus macotes");
            Console.WriteLine("3 - Sair");
        }
        public string MenuAdocao() 
        {
            Console.Clear();
            Console.WriteLine("\n\n--------------------- ADOTAR UM MASCOTE ---------------------");
            Console.WriteLine($"{nameJogador} Escolha uma espécie: ");
            Console.WriteLine("BULBASAUR");
            Console.WriteLine("IVYSAUR");
            especieMascote = Console.ReadLine().ToUpper();
            return especieMascote;
        }

        public void DesejaSaberMais()
        {
            Console.WriteLine("\n\n--------------------- VOCÊ DESEJA: ---------------------");
            Console.WriteLine($"1 - Saber mais sobre o {especieMascote}");
            Console.WriteLine($"2 - Adotar {especieMascote}");
            Console.WriteLine("3 - Voltar");
        }
        public string InformacoesMascote(Mascote mascote)
        {
            Console.Clear();
            Console.WriteLine("\n------------------------------------------------------------");
            string infos = "Nome: " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(mascote.name.ToLower()) + "\n" +
                "Altura: " + mascote.height + "\n" +
                "Peso: " + mascote.weight + "\n" +
                "Habilidades:" + "\n";

            foreach (Abilities ability in mascote.abilities)
            {
                infos += ability.ToString();
                infos += "\n";
            };

            return infos;
        }
        public int ConsultarMascotesAdotados(List<Mascote> mascotes)
        {
            Console.Clear();
            Console.WriteLine("\n-------------------------------------------------------------");
            Console.WriteLine($"Você possui {mascotes.Count} mascotes.");
            for (int indiceMascote = 0; indiceMascote < mascotes.Count; indiceMascote++)
            {
                Console.WriteLine($"{indiceMascote} - {mascotes[indiceMascote].name.ToUpper()}");
            }

            Console.WriteLine($"Qual Mascote você deseja interagir?");
            return Convert.ToInt32(Console.ReadLine());
        }
        public void Interagir()
        {
            Console.WriteLine("\n------------------------------------------------------------");
            Console.WriteLine($"{nameJogador} você deseja:");
            Console.WriteLine($"1 - Saber como {especieMascote} está");
            Console.WriteLine($"2 - Alimentar o {especieMascote}");
            Console.WriteLine($"3 - Brincar com {especieMascote}");
            Console.WriteLine($"4 - Colocar {especieMascote} para dormir");
            Console.WriteLine("5 - Voltar");
        }

        public void SucessoAdocao()
        {
            Console.Clear();
            Console.WriteLine("\n------------------------------------------------------------");
            Console.WriteLine($"{nameJogador} Mascote ADOTADO COM SUCESSO, O OVO ESTÁ CHOCANDO: ");

            Console.WriteLine(@"
              ███╗
             ██████╗
            ████████╗
            ████████║
            ████████║
            ╚█████╔╝
             ╚════╝");
        }

        public string InformacoesMascoteAdotado(Mascote mascoteEscolhido)
        {
            string infos = InformacoesMascote(mascoteEscolhido);

            infos += "Idade: " + Convert.ToInt32((DateTime.Now.Hour - mascoteEscolhido.DataNascimento.Hour) / 12) + " anos em idade tamagotchi" + "\n" +
                "Alimentação: " + mascoteEscolhido.Alimentacao + "\n" +
                "Humor: " + mascoteEscolhido.Humor + "\n" +
                "Energia: " + mascoteEscolhido.Energia;

            return infos;
        }

        public void Alimentar()
        {
            Console.Clear();
            Console.WriteLine("\n------------------------------------------------------------");
            Console.WriteLine($"{especieMascote} alimentado!");
        }

        public void Brincar()
        {
            Console.Clear();
            Console.WriteLine("\n------------------------------------------------------------");
            Console.WriteLine($"{especieMascote} se divertiu muito");
        }

        public void Dormir()
        {
            Console.Clear();
            Console.WriteLine("\n------------------------------------------------------------");
            Console.WriteLine($"{especieMascote} foi dormir!");
        }


    }
}
