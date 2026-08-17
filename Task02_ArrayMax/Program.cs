int[] numbers = { 34, 56, 32,78,4};
int maximum = numbers[0];
for(int i = 0;i< numbers.Length; i++)
{
    if(numbers[i]> maximum)
    {
        maximum = numbers[i];
    }
}
Console.WriteLine($"Max: {maximum}");