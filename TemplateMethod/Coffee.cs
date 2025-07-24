public class Coffee : CaffeineBeverage
{
    protected override void Brew()
    {
        Console.WriteLine("Dripping coffee through filter");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding sugar and milk");
    }

    protected override bool CustomerWantsCondiments()
    {
        System.Console.WriteLine("Do you want sugar and milk with your coffee (y/n)?");
        return Console.ReadLine()?.ToLower() == "y";
    }
}