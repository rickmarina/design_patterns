public class Whip : CondimentDecorator { 

    private readonly Beverage _decorated;

    public Whip(Beverage decorated)
    {
        _decorated = decorated;
    }

    public override string GetDescription()
    {
        return _decorated.GetDescription() + ", Whip";
    }

    public override double cost()
    {
        return 0.32 + _decorated.cost();
    }
}