public class TurkeyAdapter : IDuck
{
    private readonly ITurkey _turkey;

    public TurkeyAdapter(ITurkey turkey)
    {
        _turkey = turkey;
    }

    public void Quack()
    {
        _turkey.Gobble();
    }

    public void Fly()
    {
        // A turkey flies a short distance, so we can adapt it to duck's fly method
        for (int i = 0; i < 5; i++)
            _turkey.Fly();
    }
}