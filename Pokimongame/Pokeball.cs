namespace PokemonGame;
    using PokemonGame;

    public class Pokeball
{
    public int Catchrate;
    public string Color;
    public Pokemon? Pokemon;
    public bool Isopen;

    //consructor for the pokeball
    public Pokeball(int catchrate, string color, Pokemon pokemon, bool isopen)
    {
        this.Catchrate = catchrate;
        this.Color = color;
        this.Pokemon = pokemon;
        this.Isopen = false;
    }
    
    //setter for pokemon
    public void SetPokemon(Pokemon newPokemon)
    {
        Pokemon = newPokemon;
    }
    
    //getter for pokemon
    public Pokemon GetPokemon()
    {
        return Pokemon;
    }
    
    //setter for catchrate
    public void SetCatchrate(int newCatchRate)
    {
        Catchrate = newCatchRate;
    }
    
    //getter for catchrate
    public int GetCatchrate()
    {
        return Catchrate;
    }
    
    //setter for color
    public void SetColor(string newColor)
    {
        Color = newColor;
    }
    
    //getter for color
    public string GetColor()
    {
        return Color;
    }
    
    //method for pokeball being thrown

    public void Throwpokeball()
    {
        this.Isopen = true; 
        Program.slowWrite($"{Pokemon.Nickname}! i choose you!");
    }
    
    //method for pokeball being returned
    public void Returnpokeball()
    {
        this.Isopen = false;
        Program.slowWrite($"{Pokemon.Nickname}! come back!");
    }
    
}