Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int a = number % 10;
    Console.WriteLine($"{number} - {a}");
}
else if (number >= 1000 && number <= 9999)
{
    int b = (number /10)%10;
    Console.WriteLine($"{number} - {b}");
}
else if (number >= 10000 && number <= 99999)
{
    int c = (number /100)%10;
    Console.WriteLine($"{number} - {c}");
}
else if (number >= 100000 && number <= 999999)
{
    int d = (number /1000)%10;
    Console.WriteLine($"{number} - {d}");
}
else
{
    Console.WriteLine($"{number} - Третьего числа нет");
}
