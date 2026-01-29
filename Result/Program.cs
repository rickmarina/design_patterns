

using Result.Pattern;

/// <summary>
/// Result Pattern
/// This example demonstrates the Result Pattern for handling success and failure cases in a functional style.
/// This way of handling results helps to avoid exceptions for control flow and makes the code more readable and maintainable.
/// </summary>

Console.WriteLine("Result Pattern Demo!");
Console.WriteLine("====================");


var user = new User("Alice", 30);

Result<User> GetUserByName(string name)
{
    if (name == "Alice")
    {
        return Result<User>.Success(new User("Alice", 30));
    }
    else
    {
        return Result<User>.Failure("User not found");
    }
}


var result = GetUserByName("Alice").Map(user => 
{
    user.Age += 1; // Increment age
    return user;
});

result.Match(
    onSuccess: user => 
    {
        Console.WriteLine($"User found: {user.Name}, {user.Age}");
        return 0;
    },
    onFailure: message => 
    {
        Console.WriteLine($"Error: {message}");
        return -1;
    }
);
