using System.Collections;
using System.ComponentModel;

Random r = new Random();
int[] T = new int[40];
ArrayList AL = new ArrayList();
ArrayList BB = new ArrayList();
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(10, 100);
    AL.Add(T[i]);
    BB.Add(T[i]);
    Console.Write(T[i] + " ");
}
Console.WriteLine("\n");
// 1
Console.WriteLine("Maksymalny element tablicy: " + T.Max());
Console.WriteLine("\n");
// 2
Console.WriteLine("Minimalny element w tablicy: " + T.Min());
Console.WriteLine("\n");
// 3
Console.WriteLine("Rozpiętość tablicy: " + (T.Max() - T.Min()));
Console.WriteLine("\n");

// 4 i 5

// Sortowanie elementow od najmniejszego do najwiekszego
AL.Sort();

// Wypisywanie uporzadkowanych elementow
for (int j = 0; j < AL.Count; j++)
{
    Console.Write(AL[j] + " ");
}
Console.WriteLine("\n");

// usuwanie maks i min wartosci z uporzadkowanej AL
while (AL.Contains(T.Max()))
{
    AL.Remove(T.Max());
}
while (AL.Contains(T.Min()))
{
    AL.Remove(T.Min());
}

for (int j = 0; j < AL.Count; j++)
{
    Console.Write(AL[j] + " ");
}
Console.WriteLine("\n");

Console.WriteLine("vice-maksymalny element w tablicy: " + AL[AL.Count - 1]);
Console.WriteLine("vice-minimalny element w tablicy: " + AL[0]);
Console.WriteLine("\n");

// 6 i 7
int lmax = 0;
int lmin = 0;
foreach (int item in T)
{
    if (item == T.Max())
        lmax++;
    if (item == T.Min())
        lmin++;
}
Console.WriteLine($"Maksymalny element wystepuje {lmax} raz(y)");
Console.WriteLine($"Minimalny element wystepuje {lmin} raz(y)");
Console.WriteLine("\n");

// 8
/*Console.Write("Szukamy liczbe ");
int n = int.Parse(Console.ReadLine());
int k = 0;
foreach (int item in T)
{
    if (item == n)
        k++;
}
Console.WriteLine($"Podana liczba wystepuje {k} raz(y)");
Console.WriteLine("\n");
*/
// 9
double suma = 0;
foreach (int item in T)
{
    suma += item;
}
Console.WriteLine($"Srednia = {suma} / {T.Length} = {Math.Round(suma / T.Length, 1)}");

// 10
int sumaParz = 0;
for (int i = 0; i < T.Length; i += 2)
{
    sumaParz += T[i];
}
Console.WriteLine("Suma elementow tablicy znajdujacych sie pod indeksami parzystymi: " + sumaParz);

// 11
double sumaNieparz = 0;
for (int i = 1; i < T.Length; i += 2)
{
    sumaNieparz += T[i];
}
Console.WriteLine(sumaNieparz);
Console.WriteLine("Srednia elementow znajdujacych sie pod indeksami nieparzystymi: " + Math.Round(sumaNieparz / (T.Length / 2), 1));
Console.WriteLine("\n");

// 12
int b = 0;
for (int i = 0; i < T.Length; i++)
{
    int v = 0;
    for (int j = 0; j < T.Length; j++)
    {
        if (T[j] == T[i])
        {
            v++;
        }
    }
    if (v == 1)
    {
        b++;
    }
}
Console.WriteLine("Ilosc niepowtarzajacych sie elementow: " + b);

// 13
Console.Write("W tablicy nie wystepuja liczby: ");
for (int i = 10; i < 100; i++)
{
    if (T.Contains(i) == false)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine("\n");

// 14 NIE DZIALA
int a = 0;
for (int i = 10; i < 100; i++)
{
    int v = 0;
    for (int j = 0; j < T.Length; j++)
    {
        if (T[i] == T[j])
        {
            v++;
        }
    }
    if (v > 1)
    {
        a += v - 1;
    }
}
Console.WriteLine($"Należałoby usunąć {a} elementow z tablicy, aby zostały w niej wartości unikalne");
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");

// 15 NIE DZIALA
/*
BB.Insert(0, 0);
int p = 0;
int y = 0;
int ymax = 0;

for (int j = 0; j < BB.Count; j++)
{
    Console.Write(BB[j] + " ");
}
Console.WriteLine("\n");

for (int i = 1; i < BB.Count; i++)
{
    if (Convert.ToInt32(BB[i]) >= Convert.ToInt32(BB[i-1]))
    {
        y++;
    }
    else
    {
        if (y > ymax)
        {
            ymax = y;
            p = i - 1;
        }
        y = 0;
    }
    
}
Console.WriteLine($"Najdluzszy ciag zaczyna sie o pozycji {p} i ma dlugosc {ymax}");
*/
