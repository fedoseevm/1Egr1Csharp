using System.Collections;
Random R = new Random();

// 1. Wczytaj dziekniki liczny do listy
/*int n = int.Parse(Console.ReadLine());
ArrayList A = new ArrayList();
for (int i = 0; i < n + 1; i++)
{
    if (n % i == 0)
        A.Add(i);
}*/

// 2. Wczytaj do tablicy 20 losowych liczb trzycyfrowych zlozonych niepodzielnych przez 2, 3, 5, 7
/*bool czy_p(int x)
{
    for (int i = 2; i <= Math.Sqrt(x); i++)
        if (n % i == 0)
            return false;
    return true;
}
int liczba = 0;
int ilosc = 0;
int[] Tabl2 = new int[20];
while (Tabl2.Length < 20)
{
    liczba = R.Next(100, 1000);
    if (liczba % 2 != 0 && liczba % 3 != 0 && liczba % 5 != 0 && liczba % 7 != 0 && !(czy_p(liczba)))
        Tabl2[ilosc] = liczba;
}
foreach (int l in Tabl2)
    Console.Write(l + " ");*/

// 3. Wygeneruj tablice 40 losowych liczb 2-cyfrowych. Znajdz sume tych, co wystepuja podwojnie
/*int[] Tabl3 = new int[40];
int[] L = new int[100];
for (int i = 0; i < Tabl3.Length; i++)
{
    Tabl3[i] = R.Next(10, 100);
    L[Tabl3[i]]++;
}
int suma = 0;
for (int j = 0; j < L.Length; j++)
{
    if (L[j] == 2)
        suma += 2 * j;
}
Console.WriteLine(suma);*/

// Wygeneruj macierz 11-11 i znajdz sume cyfr na diagonalach
int a = int.Parse(Console.ReadLine());
int[,] M = new int[a,a];
int suma = 0;
for (int i = 0; i < M.GetLength(0); i++)
{
    for (int j = 0; j < M.GetLength(1); j++)
    {
        M[i, j] = R.Next(0, 10);
    }
}
for (int i = 0; i < M.GetLength(0); i++)
{
    for (int j = 0; j < M.GetLength(1); j++)
    {
        if (i == j || i + j == a - 1)
        {
            suma += M[i, j];
        }
    }
}
Console.WriteLine(suma);
