Console.WriteLine("**** Decorator ****");
Beverage beverage = new Expresso(); 
Console.WriteLine($"{beverage.GetDescription()} ${beverage.cost()}");


Beverage beverage1 = new HouseBlend(); 
beverage1 = new Soy(beverage1);
beverage1 = new Mocha(beverage1);

Console.WriteLine($"{beverage1.GetDescription()} ${beverage1.cost()}");

Beverage beverage2 = new Expresso(); 
beverage2 = new Soy(beverage2);
beverage2 = new Mocha(beverage2);
beverage2 = new Whip(beverage2);

Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.cost()}");


Beverage beverage3 = new Mocha(new Soy(new Expresso())); 

Console.WriteLine($"{beverage3.GetDescription()} ${beverage3.cost()}");