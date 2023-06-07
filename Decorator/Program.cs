Console.WriteLine("**** Decorator ****");
Beverage beverage = new Expresso(); 
Console.WriteLine($"{beverage.GetDescription()} ${beverage.cost()}");


Beverage beverage1 = new HouseBlend(); 
//beverage1 = new Soy(beverage1);
beverage1 = new Mocha(beverage1);

Console.WriteLine($"{beverage1.GetDescription()} ${beverage1.cost()}");


