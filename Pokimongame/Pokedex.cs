namespace PokemonGame;

public class Pokedex
{
    private static int TrueAmountPokemon = 0;
    
    private static int GetTrueAmountPokemon()
    {
        return TrueAmountPokemon;
    }

    public static void UpdateTrueAmountPokemon()
    {
        TrueAmountPokemon++;
    }
}