
Console.WriteLine("\n=== TASK 3: Age Category ===");

Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age < 13)
{
    Console.WriteLine("Child");
}
else if (age >= 13 && age <= 19)
{
    Console.WriteLine("Teen");
}
else if (age >= 20 && age <= 60)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Senior");
}