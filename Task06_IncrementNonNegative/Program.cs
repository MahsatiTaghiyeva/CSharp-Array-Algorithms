int[] nums = {1, 23, -4, 456,-7};
for(int i = 0; i< nums.Length; i++)
{
    if (nums[i] >= 0)
    {
        nums[i]+= 2;
    }
}
foreach(int num in nums)
{
    Console.WriteLine(num);
}