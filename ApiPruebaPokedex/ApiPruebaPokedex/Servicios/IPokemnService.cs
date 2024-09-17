using ApiPruebaPokedex.Entidades;

namespace ApiPruebaPokedex.Servicios
{
    public interface IPokemnService
    {
        Task<List<PokemonResponse>> GetPokemonList(int value);
    }
}
