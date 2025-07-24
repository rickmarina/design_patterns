
Console.WriteLine("Template Method Pattern!");

System.Console.WriteLine("Making tea...");
Tea tea = new();
tea.PrepareRecipe();

System.Console.WriteLine("Making coffee...");
Coffee coffee = new();
coffee.PrepareRecipe();