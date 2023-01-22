Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    Console.WriteLine("Некорректный ввод");
}
else
{
    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        sum += i;
    }
    Console.WriteLine($"Сумма чисел от M до N: {sum}");
}