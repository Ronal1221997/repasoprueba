namespace ApiPruebaPokedex.Entidades
{
    public class PokemonResponse
    {
        public int count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }
        public List<PokemonResult> results { get; set; } = new List<PokemonResult>();
    }

    public class PokemonResult
    {
        public string name { get; set; }
        public string url { get; set; }
    }

}
