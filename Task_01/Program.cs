Console.WriteLine("Введите первое число: ");
string first = Console.ReadLine();
int a = int.Parse(first);

Console.WriteLine("Введите втооое число: ");
string second = Console.ReadLine();
int b = int.Parse(second);

int max = a;

if(b > max)
{
    max = b;
}

Console.Write($"Наибольшее число: {max}");
