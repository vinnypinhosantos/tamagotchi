// See https://aka.ms/new-console-template for more information

using RestSharp;
using System.Text.Json;
using Tamagotchi.model;
using Tamagotchi.view;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mascote> MascotesAdotados;

            MascotesAdotados = new List<Mascote>();
            TamagotchiView view = new TamagotchiView();

            view.BoasVindas();

            string escolha = "0";
            
            view.MenuInicial();
            escolha = Console.ReadLine();
            if (escolha == "1") 
            {
                
                Mascote mascote = new Mascote();
                string especie = view.MenuAdocao();
                while (escolha != "3")
                {
                    view.DesejaSaberMais();
                    escolha = Console.ReadLine();
                    if (escolha == "1")
                    {
                        Console.WriteLine(especie);
                        mascote = MascoteService.BuscarCaracteristicaPorEspecie(especie);
                        Console.WriteLine(mascote);
                    }
                    else if (escolha == "2")
                    {
                        mascote = MascoteService.BuscarCaracteristicaPorEspecie(especie);
                        MascotesAdotados.Add(mascote);
                        view.SucessoAdocao();
                    }
                    else
                    {
                        escolha = "3";
                    }                    
                }
             }
        }
    }
}
    
