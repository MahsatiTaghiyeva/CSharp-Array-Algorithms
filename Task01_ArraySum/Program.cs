int[] numbers = {34, 23, 567, 98, 15 };

int sum = 0;

foreach (int number in numbers)
{
    sum += number;
}

Console.WriteLine($"Sum: {sum}");