// Рекурсивный метод использования функции Аккермана
void ZadachaonRecurs3()
{
    Console.WriteLine("Введите натуральное число M: ");
    int M = Convert.ToInt32(Console.ReadLine ());
    Console.WriteLine("Введите натуральное число N: ");
    int N = Convert.ToInt32(Console.ReadLine ());

    FunctionAkkerman(M, N);
    Console.WriteLine($"А (M, N) = {FunctionAkkerman(M, N)}");
}

ZadachaonRecurs3();

int FunctionAkkerman(int M, int N)
{
    if (M == 0 &&  N != 0)
    {
        return N + 1;
    }
    if (M > 0 && N == 0)
    {
        return FunctionAkkerman (M-1, 1);
    }
    if (M > 0 && N > 0)
    {
        return FunctionAkkerman (M-1, FunctionAkkerman (M, N-1));
    }
    return FunctionAkkerman(M, N);
}