// Рекурсивный метод нахождения суммы чисел в промежутке между M и N
void ZadachaonRecurs2()
{
    Console.WriteLine("Введите натуральное число M: ");
    int M = Convert.ToInt32(Console.ReadLine ());
    Console.WriteLine("Введите натуральное число N: ");
    int N = Convert.ToInt32(Console.ReadLine ());

    if (M > 0 && N > 0 && M <= N)
    {
        int sum = 0;
        RecursSum(M, N, sum);
        Console.WriteLine($"Сумма чисел равна {RecursSum(M, N, sum)}");
    }
    else 
    {
        Console.WriteLine ("Проверьте корректность введенных чисел");
    }
}
ZadachaonRecurs2();

int RecursSum(int M, int N, int sum = 0, int count = 0)
{
    if (count > N - M) return sum;
    sum = sum + (M + count);
    count++;
    return RecursSum(M, N, sum, count);
}

