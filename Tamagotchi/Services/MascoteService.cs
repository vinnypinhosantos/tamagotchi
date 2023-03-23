using AutoMapper;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tamagotchi.Model;

namespace Tamagotchi.Services
{
    public class MascoteService
    {
        public static Informacoes BuscarNomesDePokemons()
        {
            string API_URL = $"https://pokeapi.co/api/v2/pokemon/";
            var client = new RestClient(API_URL);
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            return JsonSerializer.Deserialize<Informacoes>(response.Content);
        }
        public static Pokemon BuscarCaracteristicaPorEspecie(string especie)
        {
            string API_URL = $"https://pokeapi.co/api/v2/pokemon/{especie.ToLower()}";
            var client = new RestClient(API_URL);
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            return JsonSerializer.Deserialize<Pokemon>(response.Content);
        }

        public static Mascote MapeiaPokemonEmMascote(Pokemon pokemon)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Pokemon, Mascote>();
            });
            var mapper = configuration.CreateMapper();
            return mapper.Map<Mascote>(pokemon);
        }
    }
}
