using AutoMapper;
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
            List<Mascote> mascotesAdotados = new List<Mascote>();
            TamagotchiView view = new TamagotchiView();

            view.BoasVindas();

            FluxoPrincipal(view, mascotesAdotados);
            
        }
        public static void FluxoPrincipal(TamagotchiView view, List<Mascote> mascotesAdotados)
        {
            string escolha = "0";
            while (escolha != "3")
            {
                view.MenuInicial();
                escolha = Console.ReadLine();
                if (escolha == "1")
                {
                    FluxoSaberMais(view, escolha, mascotesAdotados);
                }
                else if (escolha == "2")
                {

                    try
                    {
                        int indiceMascote = FluxoConsulta(view, mascotesAdotados);
                        FluxoDeInteracao(view, escolha, mascotesAdotados, indiceMascote);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Formato Inválido! Por favor digite um número!");
                        Thread.Sleep(3000);
                        int indiceMascote = FluxoConsulta(view, mascotesAdotados);
                        FluxoDeInteracao(view, escolha, mascotesAdotados, indiceMascote);
                    }

                }
                else if (escolha == "3")
                {
                    Console.WriteLine("Obrigado! Tchau.");
                }
                else
                {
                    Console.WriteLine("Opção Inválida! Tente Novamente!");
                }
            }
        }
        public static string FluxoSaberMais(TamagotchiView view, string escolha, List<Mascote> mascotesAdotados)
        {
            Pokemon pokemon = new Pokemon();
            try
            {
                Informacoes informacoes = MascoteService.BuscarNomesDePokemons();
                string especie = FluxoEspecies(view, informacoes);

                while (escolha != "3")
                {
                    view.MenuDesejaSaberMais();
                    escolha = Console.ReadLine();
                    if (escolha == "1")
                    {
                        FluxoInformacoes(view, pokemon, especie);
                    }
                    else if (escolha == "2")
                    {
                        FluxoAdocao(view, pokemon, especie, mascotesAdotados);
                        escolha = "3";
                    }
                    else if (escolha == "3")
                    {

                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida! Tente Novamente!");
                    }
                }
                escolha = "0";
                return escolha;
            }
            catch (Exception e)
            {
                Console.WriteLine("API Indisponível");
                Console.WriteLine("Erro: " + e.ToString());
                return e.ToString();
            }          
        }
        public static string FluxoEspecies(TamagotchiView view, Informacoes informacoes)
        {
            string especie = view.MenuAdocao(informacoes);

            while (!informacoes.ResultsContains(especie))
            {
                Console.WriteLine("Opção Inválida! Tente Novamente!");
                Thread.Sleep(3000);
                especie = view.MenuAdocao(informacoes);
            }

            return especie;
        }
        public static void FluxoInformacoes(TamagotchiView view, Pokemon pokemon, string especie)
        {
            try
            {
                pokemon = MascoteService.BuscarCaracteristicaPorEspecie(especie);
                Mascote mascote = MascoteService.MapeiaPokemonEmMascote(pokemon);
                Console.WriteLine(view.MenuInformacoesMascote(mascote));
            }
            catch (Exception e)
            {
                Console.WriteLine("API Indisponível");
                Console.WriteLine("Erro: "+ e);
            }
            
        }
        public static void FluxoAdocao(TamagotchiView view, Pokemon pokemon, string especie, List<Mascote> mascotesAdotados)
        {
            try
            {
                pokemon = MascoteService.BuscarCaracteristicaPorEspecie(especie);
                Mascote mascote = MascoteService.MapeiaPokemonEmMascote(pokemon);
                mascotesAdotados.Add(mascote);
                view.SucessoAdocao();
            }
            catch (Exception e)
            {
                Console.WriteLine("API Indisponível");
                Console.WriteLine("Erro: " + e);
            }         
        }
        public static int FluxoConsulta(TamagotchiView view, List<Mascote> mascotesAdotados)
        {
            int indiceMascote = view.ConsultaMascotesAdotados(mascotesAdotados);
            while (indiceMascote >= mascotesAdotados.Count || indiceMascote < 0)
            {
                Console.WriteLine("Opção inválida! Por favor, digite um número que está na lista.");
                Thread.Sleep(3000);
                indiceMascote = view.ConsultaMascotesAdotados(mascotesAdotados);
            }
            return indiceMascote;
        }
        public static void FluxoDeInteracao(TamagotchiView view, string escolha, List<Mascote> mascotesAdotados, int indiceMascote)
        {
            while (escolha != "5")
            {
                view.MenuInteragir();
                escolha = Console.ReadLine();
                if (escolha == "1")
                {
                    Console.WriteLine(view.MenuInformacoesMascoteAdotado(mascotesAdotados[indiceMascote]));
                }
                else if (escolha == "2")
                {
                    mascotesAdotados[indiceMascote].AlimentarMascote();
                    view.Alimentar();
                }
                else if (escolha == "3")
                {
                    mascotesAdotados[indiceMascote].BrincarMascote();
                    view.Brincar();
                }
                else if (escolha == "4")
                {
                    mascotesAdotados[indiceMascote].DormirMascote();
                    view.Dormir();
                }
                else if (escolha == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção Inválida! Tente Novamente!");
                }
            }
        }
    }
}
