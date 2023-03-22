// See https://aka.ms/new-console-template for more information

using RestSharp;
using System.Text.Json;
using Tamagotchi.model;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            string API_URL = "https://pokeapi.co/api/v2/pokemon/1";

            var client = new RestClient(API_URL);
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var mascote = JsonSerializer.Deserialize<Mascote>(response.Content);
                Console.WriteLine(mascote);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
            Console.ReadKey();

        }
    }
    
}
