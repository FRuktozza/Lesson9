void PrintToOne(int n)
{
    Console.Write($"{n} ");

    if (n > 1)
    {
        PrintToOne(n - 1);
    }
}

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1)
{
    Console.WriteLine("Число меньше 1");
}
else
{
    Console.WriteLine("Числа от N до 1:");
    PrintToOne(n);
}