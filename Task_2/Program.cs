Console.Clear();

int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    else
    {
        return (AkkermanFunc(m - 1, AkkermanFunc(m, n - 1)));
    }
}

Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AkkermanFunc(m, n));