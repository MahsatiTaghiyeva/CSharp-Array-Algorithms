int[] nums = { 21, 34, 48, 67, 91 };
bool exists50 = false;
for(int i = 0; i < nums.Length; i++)
{
    if(nums[i]== 50)
    {
        exists50 = true;
        Console.WriteLine(i);
        break;
    }
}
if(exists50 == false)
{
    Console.WriteLine(-1);
}