namespace ObjectOrientedAbusers.RefusedBequest.After;

public class Animal
{
    Leg[] Legs { get; }
    string Name { get; }
    
    public Animal(string name)
    {
        Name = name;
    }

    public Animal(string name, Leg[] legs) : this(name)
    {
        Legs = legs;
    }
}