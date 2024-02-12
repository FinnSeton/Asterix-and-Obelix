namespace PokemonGame;

public class trainer
{
    public string name;
    public List<Pokeball> belt;
    
    //setter for name
    public void SetName(string NewName)
    {
        name = NewName;
    }
    //getter for name
    public string GetName()
    {
        return name;
    }
    
    //setter for belt
    public void SetBelt(List<Pokeball> NewBelt)
    {
        belt = NewBelt;
    }
    //getter for belt
    public List<Pokeball> GetBelt()
    {
        return belt;
    }
    
    
} 