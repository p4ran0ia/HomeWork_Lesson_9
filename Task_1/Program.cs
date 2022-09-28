Console.Clear();

int Summa(int m, int n)
{
    if (m == n)
        return n;
    return Summa(m + 1, n) + m;
}

Console.Write("Введите минимальное значение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Summa(m, n));



