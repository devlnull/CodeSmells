namespace ObjectOrientedAbusers.RefusedBequest.After;

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public Dog(string name, Leg[] legs) : base(name, legs)
    {
    }
}