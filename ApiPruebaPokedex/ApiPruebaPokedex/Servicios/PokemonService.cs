using ApiPruebaPokedex.Entidades;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace ApiPruebaPokedex.Servicios
{
    public class PokemonService : IPokemnService
    {
        public async Task<List<PokemonResponse>> GetPokemonList(int value)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://pokeapi.co/api/v2/pokemon?limit=" + value);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            response.Content.ToString();

            var response1 = await response.Content.ReadAsStringAsync();

           var responseP = JsonSerializer.Deserialize<PokemonResponse>(response1);

            if (responseP != null)
            {
                return new List<PokemonResponse>() { responseP };
            }
            
            return  new List<PokemonResponse>();
        }
    }
}
