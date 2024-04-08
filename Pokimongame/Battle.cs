namespace PokemonGame;

public class Battle
{
    public Rounds round;


    public Battle()
    {
        this.round = new Rounds();
    }
    
// Game loop
    public int  doRounds()
    {
        if (round.Pokemon1.strength == round.Pokemon2.weakness)
        {
            return 1;
        }
        else if (round.Pokemon2.strength == round.Pokemon1.weakness)
        {
            return 2;
        }
        else 
        {
            return 0;
        }
        
    }

    public void setupRound(Pokemon pokemon1, Pokemon pokemon2)
    {
        round.Pokemon1 = pokemon1;
        round.Pokemon2 = pokemon2;
    }
}