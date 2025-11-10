// Task 1: Operators
Console.WriteLine("=== TASK 1: Operators ===");

Operators ops = new Operators();

// Call all methods
ops.Add(10, 5);
ops.Subtract(10, 5);
ops.Multiply(10, 5);
ops.Divide(10, 5);

// Test OddEvenFinder with different numbers
ops.OddEvenFinder(7);
ops.OddEvenFinder(8);
ops.OddEvenFinder(0);