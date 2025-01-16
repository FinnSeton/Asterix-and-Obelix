namespace PokemonGame;
    using PokemonGame;

    public class Pokeball
{
    private int Catchrate { get; set; }
    private string Color { get; set; }
    public Pokemon? Pokemon { get; set; }
    private bool Isopen { get; set; }

    //consructor for the pokeball
    public Pokeball(int catchrate, string color, Pokemon pokemon, bool isopen)
    {
        this.Catchrate = catchrate;
        this.Color = color;
        this.Pokemon = pokemon;
        this.Isopen = false;
    }
    
    //setter for pokemon
    private void SetPokemon(Pokemon newPokemon)
    {
        Pokemon = newPokemon;
    }
    
    //getter for pokemon
    private Pokemon GetPokemon()
    {
        return Pokemon;
    }
    
    //setter for catchrate
    private void SetCatchrate(int newCatchRate)
    {
        Catchrate = newCatchRate;
    }
    
    //getter for catchrate
    private int GetCatchrate()
    {
        return Catchrate;
    }
    
    //setter for color
    private void SetColor(string newColor)
    {
        Color = newColor;
    }
    
    //getter for color
    private string GetColor()
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
    private void Returnpokeball()
    {
        this.Isopen = false;
        Program.slowWrite($"{Pokemon.Nickname}! come back!");
    }
    
}