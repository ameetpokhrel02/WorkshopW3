public class Operators
{
    // 1. Basic arithmetic operations
    public void Add(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine($"Sum: {sum}");
    }
    
    public void Subtract(int a, int b)
    {
        int difference = a - b;
        Console.WriteLine($"Difference: {difference}");
    }
    
    public void Multiply(int a, int b)
    {
        int product = a * b;
        Console.WriteLine($"Product: {product}");
    }
    
    public void Divide(int a, int b)
    {
        int result = a / b;
        Console.WriteLine($"Division Result: {result}");
    }
    
    // 2. OddEvenFinder using Ternary Operator (from lecture)
    public void OddEvenFinder(int number)
    {
        // Ternary operator ? : (from lecture slides)
        string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
        Console.WriteLine(result);
    }
}