using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.model;

namespace Tamagotchi.view
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
        public int ConsultarMascotes(List<Mascote> mascotes)
        {
            Console.WriteLine("\n-------------------------------------------------------------");
            Console.WriteLine($"Você possui {mascotes.Count} mascotes.");
            for (int indicePokemon = 0; indicePokemon < mascotes.Count; indicePokemon++)
            {
                Console.WriteLine($"{indicePokemon} - {mascotes[indicePokemon].name.ToUpper()}");
            }

            Console.WriteLine($"Qual Pokemon você deseja interagir?");
            return Convert.ToInt32(Console.ReadLine());
        }
        public void SucessoAdocao()
        {
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
    }
}
