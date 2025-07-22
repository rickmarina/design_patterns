// Adapter pattern: This code demonstrates the Adapter pattern, which allows incompatible interfaces to work together.

Console.WriteLine("***** Adapter pattern *****");

// Object implementation 
MallardDuck mallardDuck = new MallardDuck();
WildTurkey wildTurkey = new WildTurkey();
IDuck turkeyAdapter = new TurkeyAdapter(wildTurkey);

System.Console.WriteLine("The Turkey says...");
wildTurkey.Gobble();
wildTurkey.Fly();

System.Console.WriteLine("\nThe Duck says...");
TestDuck(mallardDuck);

System.Console.WriteLine("\nThe TurkeyAdapter says...");
TestDuck(turkeyAdapter);


// Class implementation 


static void TestDuck(IDuck duck)
{
    duck.Quack();
    duck.Fly();
}
