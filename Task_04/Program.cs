int N = new Random().Next(0, 10);
int count = 0;
while(count < N)
{
    if(count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}
