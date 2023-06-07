public class Mocha : CondimentDecorator { 

    private readonly Beverage _decorated;

    public Mocha(Beverage decorated)
    {
        _decorated = decorated;
    }

    public override string GetDescription()
    {
        return _decorated.GetDescription() + ", Mocha";
    }

    public override double cost()
    {
        return 0.20 + _decorated.cost();
    }
}