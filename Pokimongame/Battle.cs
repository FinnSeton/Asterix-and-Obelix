namespace PokemonGame;

public class Battle
{
    public Rounds Round;


    public Battle()
    {
        this.Round = new Rounds();
    }
    
// Game loop
    public int  DoRounds()
    {
        if (Round.Pokemon1.Strength == Round.Pokemon2.Weakness)
        {
            return 1;
        }
        else if (Round.Pokemon2.Strength == Round.Pokemon1.Weakness)
        {
            return 2;
        }
        else 
        {
            return 0;
        }
        
    }

    public void SetupRound(Pokemon pokemon1, Pokemon pokemon2)
    {
        Round.Pokemon1 = pokemon1;
        Round.Pokemon2 = pokemon2;
    }
}