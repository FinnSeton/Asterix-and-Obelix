namespace PokemonGame;

public class Arena
{
    public Trainer Trainer1;
    public Trainer Trainer2;

    public int WinsTrainer1;
    public int LosesTrainer1;
    public int WinsTrainer2;
    public int LosesTrainer2;
    public int Rounds;
    public Battle Battle;

    public Arena(Trainer trainer1, Trainer trainer2)
    {
        this.Trainer1 = trainer1;
        this.Trainer2 = trainer2;
    }

    public void DoBattle()
    {
        Program.slowWrite($"Trainer {Trainer1.GetName()} enterd the arena");
        Program.slowWrite(" ");
        Program.slowWrite($"Trainer {Trainer2.GetName()} Enterd the arena");
        Program.slowWrite(" ");
        Pokemon pokemonTrainer1 = Trainer1.ThrowPokeball().Pokemon;
        Pokemon pokemonTrainer2 = Trainer2.ThrowPokeball().Pokemon;
        Trainer lastLoser = null;

        this.Battle = new Battle();

        for (int i = 0; i < 6; i++)
        {
            Battle.SetupRound(pokemonTrainer1, pokemonTrainer2);
            int result = Battle.DoRounds();

            if (result == 1)
            {
                lastLoser = Trainer2;
                WinsTrainer1++;
                LosesTrainer2++;
                Program.slowWrite($"{Trainer1.GetName()} has won this round!"); 
                Program.slowWrite(" ");
                Trainer2.ReturnPokemon(pokemonTrainer2);
                pokemonTrainer2 = Trainer2.ThrowPokeball().Pokemon;

            }
            else if (result == 2)
            {
                WinsTrainer2++;
                LosesTrainer1++;
                lastLoser = Trainer1;
                Program.slowWrite($"{Trainer2.GetName()} has won this round ");
                Program.slowWrite($" ");
                Trainer1.ReturnPokemon(pokemonTrainer1);
                pokemonTrainer1 = Trainer1.ThrowPokeball().Pokemon;
            }
            else
            {
                Program.slowWrite(" Its a draw nobody gets a point ");

                if (lastLoser == Trainer1)
                {
                    Trainer2.ReturnPokemon(pokemonTrainer2);
                    pokemonTrainer2 =Trainer2.ThrowPokeball().Pokemon;
                }
                else if (lastLoser == Trainer2)
                {
                    Trainer1.ReturnPokemon(pokemonTrainer1);
                    pokemonTrainer1 = Trainer1.ThrowPokeball().Pokemon;
                }
                else
                {
                    Trainer2.ReturnPokemon(pokemonTrainer2);
                    Trainer1.ReturnPokemon(pokemonTrainer1);
                    pokemonTrainer2 =Trainer2.ThrowPokeball().Pokemon;
                    pokemonTrainer1 = Trainer1.ThrowPokeball().Pokemon;
                }
            }

            Program.slowWrite($"{Trainer1.GetName()} has won {WinsTrainer1} times");
            Program.slowWrite($" ");

            Program.slowWrite($"{Trainer2.GetName()} has won {WinsTrainer2} times");
            Program.slowWrite($" ");
            Rounds++;
        }
    }

    public string Checkwinner()
    {
        if (WinsTrainer1 > WinsTrainer2)
        {
            return "Conrats you have won do you wanna play again?";
        }
        else if (WinsTrainer2 > WinsTrainer1)
        {
            return "you have lost. do you wanna play again?";
        }
        else
        {
            return "its a draw. do you wanna play again?";
        }
    }
}