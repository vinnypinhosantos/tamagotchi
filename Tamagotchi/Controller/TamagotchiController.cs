using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Model;
using Tamagotchi.Services;
using Tamagotchi.View;

namespace Tamagotchi.Controller
{
    public static class TamagotchiController
    {
        public static void Jogar()
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
                else if (escolha == "3")
                {
                    Console.WriteLine("Obrigado! Tchau.");
                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                }
            }
        }
    }
}
