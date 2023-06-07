public class Soy : CondimentDecorator { 

    private readonly Beverage _decorated;

    public Soy(Beverage decorated)
    {
        _decorated = decorated;
    }

    public override string GetDescription()
    {
        return _decorated.GetDescription() + ", Soy";
    }

    public override double cost()
    {
        return 0.45 + _decorated.cost();
    }
}