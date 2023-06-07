Random r = new Random();

// WSTEP
// 1. Oblicz sumę liczb 3-cyfrowych
int zad_1()
{
    int suma = 0;
    for (int i = 100; i < 1000; i++)
        suma += i;
    return suma;
}
Console.WriteLine($"Suma liczb 3-cyfrowych: {zad_1()}");
Console.WriteLine();

// Oblicz sumę i ilość dwucyfrowych wielokrotności liczby 6
void zad_2()
{
    int suma = 0;
    int ilosc = 0;
    for (int i = 10; i < 100; i += 2)
        if (i % 6 == 0)
        {
            suma += i;
            ilosc++;
        }
    Console.WriteLine(suma + " " + ilosc);
}
zad_2();
Console.WriteLine();

// 3. Znajdź największą liczbę wśród 5 wylosowanych przez program liczb 4-cyfrowych
int zad_3()
{
    int[] T = new int[5];
    for (int i = 0; i < T.Length; i++)
        T[i] = r.Next(1000, 10000);
    return T.Max();
}
Console.WriteLine(zad_3());
Console.WriteLine();

// 4. Podaj sumę cyfr w dowolnej liczbie
int zad_4(int x)
{
    int suma = 0;
    while (x > 0)
    {
        suma += x % 10;
        x /= 10;
    }
    return suma;
}
int x = int.Parse(Console.ReadLine());
Console.WriteLine(zad_4(x));
Console.WriteLine();

// 5. Znajdź najmniejszą cyfrę we wpisanej przez usera liczbie 3-cyfrowej
int zad_5(int x)
{
    int min_cyfra = 9;
    while (x > 0)
    {
        if (x % 10 < min_cyfra)
            min_cyfra = x % 10;
        x /= 10;
    }
    return min_cyfra;
}
int n = int.Parse(Console.ReadLine());
Console.WriteLine(zad_5(n));
Console.WriteLine();
