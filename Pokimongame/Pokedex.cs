namespace PokemonGame;

public class Pokedex
{
    public static int TrueAmountPokemon = 0;

    public Pokedex()
    {
        
    }

    public static int getTrueAmountPokemon()
    {
        return TrueAmountPokemon;
    }

    public static void UpdateTrueAmountPokemon()
    {
        TrueAmountPokemon++;
    }
}