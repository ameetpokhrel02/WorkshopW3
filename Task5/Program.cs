Console.WriteLine("\n=== TASK 5: Loops ===");

Console.Write("Enter a number N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= N; i++)
{
    sum += i;
}
Console.WriteLine($"Sum from 1 to {N}: {sum}");

Console.WriteLine("Numbers from 1 to 20 (skip multiples of 4, stop at 15):");
int num = 1;
while (num <= 20)
{
    if (num == 15)
    {
        break;
    }
    if (num % 4 == 0)
    {
        num++;
        continue;
    }
    Console.WriteLine(num);
    num++;
}

int[] numbers = { 1, 2, 3, 4, 5 };
int arraySum = 0;

foreach (int number in numbers)
{
    arraySum += number;
}
Console.WriteLine($"Sum of array elements: {arraySum}");