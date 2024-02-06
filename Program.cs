using System;

class Program
{
    public static void Main(string[] args)
    {
        Pokemon pikachu = new Pokemon();
        pikachu.Newpokimon("Pikachu", "Fire", "Water");
        Console.WriteLine(pikachu.getName());
        Console.WriteLine(pikachu.getType());
        Console.WriteLine(pikachu.getWeakness());






    }
}

class Pokemon
{
    public string name;
    public string type;
    public string weakness;

    public void Newpokimon(string name, string weakness, string type)
    {
        this.name = name;
        this.type = type;
        this.weakness = weakness;
    }

    public string getName()
    { 
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public string getWeakness()
    { 
        return weakness;
    }
    public void setWeakness(string weakness)
    {
        this.weakness = weakness;
    }

    public string getType()
    {
        return type;
    }

    public void setType(string type)
    {
        this.type = type;
    }

    public String growl()
    {
        return "Growlllll, ik ben " + this.name;
    }

}