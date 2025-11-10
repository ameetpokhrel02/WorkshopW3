// Task 6: Try Catch Finally
Console.WriteLine("\n=== TASK 6: Exception Handling ===");

// Part 1: Number conversion with try-catch-finally
try
{
    Console.Write("Enter a number: ");
    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);
    Console.WriteLine($"You entered: {number}");
}
catch (FormatException)
{
    Console.WriteLine("Invalid number format");
}
finally
{
    Console.WriteLine("Program Executed");
}

// Part 2: Password validation with throw
Console.Write("Enter password: ");
string password = Console.ReadLine();

try
{
    if (password.Length < 6)
    {
        throw new Exception("Password must be at least 6 characters.");
    }
    else
    {
        Console.WriteLine("Password satisfied the requirement");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}