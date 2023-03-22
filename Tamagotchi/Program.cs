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
            while (escolha != "3")
            {
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
                            escolha = "3";
                        }
                        else
                        {
                            escolha = "3";
                        }
                    }
                    escolha = "0";
                }
                else if (escolha == "2")
                {
                    view.ConsultarMascotes(MascotesAdotados);
                }
            }
        }
    }
}
    
