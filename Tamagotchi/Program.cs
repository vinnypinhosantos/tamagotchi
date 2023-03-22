// See https://aka.ms/new-console-template for more information

using RestSharp;
using System.Text.Json;
using Tamagotchi.Model;
using Tamagotchi.View;
using Tamagotchi.Controller;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            TamagotchiController.Jogar();
        }
    }
}
    
