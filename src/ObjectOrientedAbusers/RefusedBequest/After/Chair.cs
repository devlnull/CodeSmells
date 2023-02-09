namespace ObjectOrientedAbusers.RefusedBequest.After;

public class Chair
{
    Leg[] Legs { get; set; }
    string Name { get; set; }

    public Chair(string name)
    {
        Name = name;
    }

    public Chair(string name, Leg[] legs) : this(name)
    {
        Legs = legs;
    }
}