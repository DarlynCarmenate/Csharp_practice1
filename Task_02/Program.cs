int a = new Random().Next(0, 50);
int b = new Random().Next(0, 50);
int c = new Random().Next(0, 50);
Console.WriteLine($"{a}, {b}, {c}");

if(a > b && a > c)
{
    Console.WriteLine($"Максимальное число: {a}");
}
else if(b > c && b > a)
{
    Console.WriteLine($"Максимальное число: {b}");
}
else
{
    Console.WriteLine($"Максимальное число: {c}");
}
