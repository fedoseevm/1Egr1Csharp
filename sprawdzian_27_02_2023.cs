// zadanie 3

using System.Collections;

Random r = new Random();
ArrayList AL = new ArrayList();
for (int i = 0; i < 90; i++)
{
    AL.Add(r.Next(10, 100));
    Console.Write(AL[i] + " ");
}
Console.WriteLine("\n");


int suma = 0;
for (int i = 10; i < 100; i++)
{
    if (AL.Contains(i)) ;
    else
        suma += i;
}
Console.WriteLine("Suma liczb dwucyfrowych, ktorych nie ma w tablicy: " + suma);
Console.ReadKey();
Console.WriteLine("\n");

// zadanie 4
int[,] M = new int[15, 15];
int summ = 0;
for (int i = 0; i < M.GetLength(0); i++)
{
    for (int j = 0; j < M.GetLength(1); j++)
    {
        M[i, j] = r.Next(0, 10);
        if (i == 0 || i == M.GetLength(0) - 1 || j == 0 || j == M.GetLength(1) - 1)
        {
            summ += M[i, j];
        }
    }
}
Console.WriteLine("Suma:" + summ);


// zadanie 1
/*using System.Collections;

int n = int.Parse(Console.ReadLine());
ArrayList AL = new ArrayList();
for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        AL.Add(i);
    }
}
Console.WriteLine("\n");

Console.Write($"Dzielniki liczby {n}:  ");
for (int j = 0; j < AL.Count; j++)
{
    Console.Write(AL[j] + "  ");
}


// zadanie 2
bool czy_p(int x)
{
    bool flaga = true;
    for (int i = 0; i <= Math.Sqrt(x); i++)
    {
        if (x % i == 0)
            flaga = false;
    }
    if (flaga)
        return true;
    else
        return false;
}

ArrayList T = new ArrayList();
Random r = new Random();
for (int i = 0; i < 1000; i++)
{
    int x = r.Next(100, 1000);
    if (x % 2 != 0 && x % 3 != 0 && x % 5 != 0 && x % 7 != 0 && !(czy_p(x)))
    {
        T.Add(x);
        if (T.Count == 20)
            break;
    }
}
*/
