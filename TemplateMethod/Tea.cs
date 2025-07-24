public class Tea : CaffeineBeverage
{
    protected override void Brew()
    {
        Console.WriteLine("Steeping the tea");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding lemon");
    }

    protected override bool CustomerWantsCondiments()
    {
        System.Console.WriteLine("Do you want lemon with your tea (y/n)?");
        return Console.ReadLine()?.ToLower() == "y";
    }
}