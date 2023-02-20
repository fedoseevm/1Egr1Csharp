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


/*
// Tablice 2D
int[,] M = new int[2, 2];   // deklaracja
M[0, 0] = 3;
M[0, 1] = 9;   // definicja
M[0, 2] = 6;
M[1, 0] = 0;
M[1, 1] = 7;
M[1, 2] = 7;
M[2, 0] = 1;
M[2, 1] = 3;
M[2, 2] = 8;

int[,] N = new int[,] { { 2, 3, 4, 5 }, { 7, 8, 9, 10 }, { 16, 17, 18, 19 } };
Console.WriteLine(N[1, 3]);
for (int i = 0; i < N.Length; i++)
{
    Console.Write(N[i / N.GetLength(1), i % N.GetLength(1)] + " ");
}
Console.WriteLine("\n");

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
