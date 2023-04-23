/*//Tablice 1D

// prosta deklaracja i pozniej definicja
int[] T = new int[3];   // deklaracja - podanie zmiennych

T[0] = 3;
T[1] = 5;   // definicja - przypisywanie konkretnych wartosci
T[2] = 6;

// mozna polaczyc deklaracje i definicje
int[] S = new int[] { 5, 6, 12, 0, 9, 3 };


// przejsie po tablicy - 2 podstawowe warianty przejsc
for (int i = 0; i < S.Length; i++)
{
    Console.Write(S[i] + " ");
}
Console.WriteLine("\n");


foreach (var item in S)         // var - nowoczesne rozwiazanie; mozna (int)
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");


// Wypelnianie tablicy liczbami losowymi
int n = int.Parse(Console.ReadLine());
Random r = new Random();
int[] L = new int[n];
for (int i = 0; i < L.Length; i++)
{
    L[i] = r.Next(1, 21);
    Console.Write(L[i] + " ");
}*/








// Tablice 2D

int[,] M = new int[2, 2];   // deklaracja
M[0, 0] = 3;
M[0, 1] = 9;   // definicja
M[1, 0] = 0;
M[1, 1] = 7;

int[,] N = new int[,] { { 2, 3, 4, 5 }, { 7, 8, 9, 10 }, { 16, 17, 18, 19 } };

Console.WriteLine(N[1, 3]);
Console.WriteLine(N[0, 1]);

for (int i = 0; i < N.Length; i++)
{
    Console.Write(N[i / N.GetLength(1), i % N.GetLength(1)] + " ");
}
Console.WriteLine("\n");


// N.GetLength(0) -- zwraca ilosc podtablic w sobie, czyli w tym przypadku 3
// N.GetLength(1) -- zwraca ilosc elementow w podtablicę, czyli w tym przypadku 4


for (int i = 0; i < N.GetLength(0); i++)
{
    for (int j = 0; j < N.GetLength(1); j++)
    {
        Console.Write(N[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");

// Losowe generowanie macierzy (tablicy dwuelementowej)
/*
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
Random r = new Random();
int[,] R = new int[n, m];
Console.WriteLine("\n");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        R[i, j] = r.Next(1, 101);
        Console.Write(R[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");
*/






// List i ArrayList
/*
using System.Collections;
ArrayList AL = new ArrayList();
AL.Add(5);
AL.Add(8);
AL.Add(4);
AL.Add(12);
AL.Add(12);
// . . . . . . ile chce tych Add
Console.WriteLine(AL.Count);
AL.Remove(5);       // usuwa wartosc
AL.RemoveAt(0);     // usuwa index
Console.WriteLine(AL.Count);
*/

// petla po ArrayList - mizna stosowac for i foreach
/*
for (int i = 0; i < AL.Count; i++)
{
    Console.Write(AL[i] + " ");
}

foreach (var item in AL)
{
    Console.Write(item + " ");
}
Console.WriteLine();
*/





// Jako ratunkowe moze byc...
//enuma definiujemy w namespace a uruchamiany w jakiejs klasie z metoda Main()
namespace Enumy     // nazwa dowolna
{

    enum Dni { Pon, Wt, Sr, Czw};
    class Alex      // nazwa dowolna
    {
        public static void Main()
        {
            Console.WriteLine(Dni.Pon);
        }
    }


}
