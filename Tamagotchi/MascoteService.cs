using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tamagotchi.model;

namespace Tamagotchi
{
    public class MascoteService
    {
        public static Mascote BuscarCaracteristicaPorEspecie(string especie)
        {
            string API_URL = $"https://pokeapi.co/api/v2/pokemon/{especie.ToLower()}";
            var client = new RestClient(API_URL);
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            return(JsonSerializer.Deserialize<Mascote>(response.Content));
        }
    }
}
