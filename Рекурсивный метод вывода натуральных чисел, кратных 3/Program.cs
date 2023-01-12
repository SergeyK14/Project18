// Рекурсивный метод вывода натуральных чисел, кратных 3
void ZadachaonRecurs1()
{
    Console.WriteLine("Введите натуральное число M: ");
    int M = Convert.ToInt32(Console.ReadLine ());
    Console.WriteLine("Введите натуральное число N: ");
    int N = Convert.ToInt32(Console.ReadLine ());

    if (M > 0 && N > 0 && M <= N)
    {
        ThreeRecurs(M, N);
    }
    else 
    {
        Console.WriteLine ("Проверьте корректность введенных чисел");
    }
}
ZadachaonRecurs1();

void ThreeRecurs(int M, int N)
{
    if (M > N) return;
    if (M%3 == 0)
    {
        Console.WriteLine($"Кратное число: {M}");
    }
    M++;
    ThreeRecurs(M, N); 
} 
