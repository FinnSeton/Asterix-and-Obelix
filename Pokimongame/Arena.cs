namespace PokemonGame;

public class Arena
{
    public Trainer Trainer1;
    public Trainer Trainer2;
    
    public int wins_trainer1;
    public int loses_trainer1;
    public int wins_trainer2;
    public int loses_trainer2;
    public int rounds;
    public Battle battle;

    public Arena(Trainer trainer1, Trainer trainer2)
    {
        this.Trainer1 = trainer1;
        this.Trainer2 = trainer2;
        
    }

    public void doBattle()
    {
        this.battle = new Battle();
        for (int i = 0; i < 6; i++)
        {
            
            battle.setupRound(Trainer1.ThrowPokeball().pokemon, Trainer2.ThrowPokeball().pokemon);
            int result = battle.doRounds();

            if (result == 1)
            {
                wins_trainer1++;
                loses_trainer2++;
            }
            else if (result == 2)
            {
                wins_trainer2++;
                loses_trainer1++;
            }

            rounds++;
        }
    }

    public string checkwinner()
    {
        
        if (wins_trainer1 > wins_trainer2)
        {
            return "Conrats you have won do you wanna play again?";
        }
        else if (wins_trainer2 > wins_trainer1)
        {
            return "you have lost. do you wanna play again?";
        }
        else
        {
            return "its a draw. do you wanna play again?";
        }
    }
    
    

}