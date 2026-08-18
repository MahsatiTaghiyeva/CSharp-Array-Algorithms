int n = 23452;
int count = 0;
while (n > 0)
{
    n/=10; //2
    count++;
}
Console.WriteLine(count);