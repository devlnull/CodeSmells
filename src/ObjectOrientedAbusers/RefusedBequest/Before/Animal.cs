namespace ObjectOrientedAbusers.RefusedBequest.Before;

public class Animal
{
    byte Legs { get; }
    string Name { get; }
    
    public Animal(string name)
    {
        Name = name;
    }

    public Animal(string name, byte legs) : this(name)
    {
        Legs = legs;
    }
}