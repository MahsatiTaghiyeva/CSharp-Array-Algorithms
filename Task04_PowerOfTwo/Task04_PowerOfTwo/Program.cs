int n = 56;
bool isQuvveti = true; 
while (n > 1)
{
    if(n%2 == 1)
    {
        isQuvveti = false;
        break;
    }
    n/=2; //4 2 1
}
if (isQuvveti == true)
{
    Console.WriteLine("Quvvetidir");

} else
    Console.WriteLine("Quvveti deyil");
