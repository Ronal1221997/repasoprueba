using ApiPruebaPokedex.Entidades;
using ApiPruebaPokedex.Servicios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ApiPruebaPokedex.Controllers
{
    public class PokemonController : ControllerBase
    {
        private readonly IPokemnService _pokemnService;

        public PokemonController(IPokemnService pokemnService) {

            _pokemnService = pokemnService;
        
        }
        
        [HttpGet("pokemonlist")]
        public async Task<ActionResult<List<PokemonResponse>>> GetPokemonList([FromHeader] int value )
        {

            try
            {

                var result = await _pokemnService.GetPokemonList(value);

                return Ok(result);

            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);

            }
        }
    }
}
