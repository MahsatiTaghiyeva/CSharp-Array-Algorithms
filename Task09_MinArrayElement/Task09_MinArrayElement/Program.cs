int[] nums = [12, 3, 87, 7, 6, 12];
int min = nums[0];
for(int i =0; i<nums.Length; i++)
{
    if(nums[i] < min)
    {
        min = nums[i];
    }
}
Console.WriteLine($"Min: {min}");