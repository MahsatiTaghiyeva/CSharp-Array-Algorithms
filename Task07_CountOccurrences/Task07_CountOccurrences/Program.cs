int[] nums = [1, 2, 3, 2, 4, 2];
int count = 0;
int find = 2;
foreach(int num in nums){
    if(num == find)
    {
        count++;
    }
}
Console.WriteLine($"Count of {find}: {count}");