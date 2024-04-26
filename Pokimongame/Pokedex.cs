namespace PokemonGame;

public class Pokedex
{
    public static int TrueAmountPokemon = 0;

    public Pokedex()
    {
        
    }

    public static int GetTrueAmountPokemon()
    {
        return TrueAmountPokemon;
    }

    public static void UpdateTrueAmountPokemon()
    {
        TrueAmountPokemon++;
    }
}