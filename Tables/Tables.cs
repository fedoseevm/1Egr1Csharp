//int a = 3;
//int b = 5;
//int c = 6;

/*int[] T = new int[4];
T[0] = 3;
T[1] = 5;
T[2] = 6;
T[3] = 7;*/

/*int[] L = new int[] { 3, 5, 6, 7, 11 };
for (int i = 0; i < L.Length; i++)
    Console.WriteLine(L[i]);*/


// uzytkownik podaje ilosc elementow listy i same liczby
/*int n = int.Parse(Console.ReadLine());
int[] W = new int[n];
for (int i = 0; i < n; i++)
{
    W[i] = int.Parse(Console.ReadLine());
}
Console.Write("Lista: ");
for (int i = 0; i < W.Length; i++)
{
    Console.Write(W[i] + " ");
}
*/


// tablica z n liczb wpisanych przez usera, wypisz ostatnia z nich
//Console.Write("Podaj ilosc elementow: ");
/*int n = int.Parse(Console.ReadLine());
int last = 0;
int[] L = new int[n];
for (int i = 0; i < n; i++)
{
    L[i] = int.Parse(Console.ReadLine());
    last = L[i];
}
Console.WriteLine("Ostatnia liczba listy: " + L[n-1]);*/

// tablica z n liczb wpisanych przez usera, wypisz sume tych liczb
/*int n = int.Parse(Console.ReadLine());
int suma = 0;
int[] L = new int[n];
for (int i = 0; i < n; i++)
{
    L[i] = int.Parse(Console.ReadLine());
    suma += L[i];
}
Console.WriteLine("Suma liczb: " + suma);*/

// tablica z n liczb wpisanych przez usera, wypisz najwiekszwe liczby
/*int n = int.Parse(Console.ReadLine());
int max = int.MinValue;
int k = 1;
int[] A = new int[n];
for (int i = 0; i < n; i++)
{
    A[i] = int.Parse(Console.ReadLine());
    if (A[i] > max)
        max = A[i];
    else if (A[i] == max)
        k++;
}
Console.WriteLine("Max Value: " + max + " ");
Console.Write("Max Value Count: " + k);*/

// tablica z n liczb wpisanych przez usera, wypisz sume liczb o parzystych indeksach
/*int n = int.Parse(Console.ReadLine());
int sum = 0;
int[] B = new int[n];
for (int i = 0; i < n; i++)
{
    B[i] = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
        sum += B[i];
}
Console.WriteLine(sum);*/





/*
Wygeneruj tablicę n losowych liczb:
Random r = new Random()
r.Next(pocz, kon)
n = 10 w przedziale [1,20]
1. Znajdź największą liczbę w tablicy
2. Znajdź najmniejszą liczbę w tablicy
3. Podaj ile razy występuje najwieksza liczba w tablicy
4. Podaj ile razy występuje najmniejsza liczba w tablicy
5. Podaj rozpiętość tablicy (różnica max - min)
6. Podaj sumę liczb w tablicy
7. Podaj średnią wartość liczb w tablicy
8. Których liczb jest więcej w tablicy: parzystych czy nieparzystych?
9. Ile w tablicy jest liczb pierwszych?
10. Podaj v-ce max i v-ce min liczb tablicy
*/


/*
Random r = new Random();
int[] T = new int[10];
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 20);
}
for (int i = 0; i < T.Length; i++)
{
    Console.Write(T[i] + " ");
}*/

// zad 1
//int maxval = int.MinValue;
using System.ComponentModel.DataAnnotations;

/*Random r = new Random();
int[] T = new int[20];*/
/*for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 20);
}
for (int i = 0; i < T.Length; i++)
{
    Console.Write(T[i] + " ");
    if (T[i] > maxval)
        maxval = T[i];
}
Console.WriteLine("\t" + maxval);*/
//Console.WriteLine(T.Max());

// zad 2
/*int minval = int.MaxValue;
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 20);
}
for (int i = 0; i < T.Length; i++)
{
    Console.Write(T[i] + " ");
    if (T[i] < minval)
        minval = T[i];
}
Console.WriteLine("\t" + minval);*/

// zad 3
/*int maxval = int.MinValue;
int k = 0;
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 20);
    Console.Write(T[i] + " ");
    if (T[i] > maxval)
        maxval = T[i];
}
for (int i = 0; i < T.Length; i++)
    if (T[i] == maxval)
        k++;
Console.WriteLine("\t" + k + "\t" + maxval);*/

// zad 4
/*int minval = int.MaxValue;
int k = 0;
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 20);
    Console.Write(T[i] + " ");
    if (T[i] < minval)
        minval = T[i];
}
for (int i = 0; i < T.Length; i++)
    if (T[i] == minval)
        k++;
Console.Write("\t" + k + "\t" + minval);*/

// zad 5
/*int maxval = int.MinValue;
int minval = int.MaxValue;
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 20);
    Console.Write(T[i] + " ");
    if (T[i] > maxval)
        maxval = T[i];
    if (T[i] < minval)
        minval = T[i];
}
Console.WriteLine();
Console.WriteLine("MAX:" + maxval);
Console.WriteLine("MIN:" + minval);
Console.WriteLine(maxval - minval);*/

// zad 6
/*int suma = 0;
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 20);
    Console.Write(T[i] + " ");
    suma += T[i];
}
Console.WriteLine();
Console.Write(suma);*/

// zad 7
//int suma = 0;
//for (int i = 0; i < T.Length; i++)
//{
//    T[i] = r.Next(1, 20);
//    Console.Write(T[i] + " ");
//    suma += T[i];
//}
//Console.WriteLine();
//Console.WriteLine("Srednia arytmetyczna: " +Math.Round(suma / 20d, 1));

// zad 8
/*int p = 0;
int n = 0;
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 20);
    Console.Write(T[i] + " ");
    if (T[i] % 2 == 0)
        p++;
    else
        n++;
}
Console.WriteLine();
if (p > n)
    Console.WriteLine("Parzystych jest wiecej");
else if ( n > p)
    Console.WriteLine("Nieparzystych jest wiecej");
if (p == n)
    Console.WriteLine("Liczba parzystych i nieprazystycj jest rowna");*/

// zad 9
/* int k = 0;
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 20);
    Console.Write(T[i] + " ");
    bool sprawdzenie = true;
    for (int j = 2; j < Math.Pow(T[i], 0.5) + 1; j++)
    {
        if ((T[i] % j == 0))
        {
            sprawdzenie = false;
            break;
        }
        if (sprawdzenie)
            k++;
    }
}
Console.WriteLine();
Console.WriteLine(k); */

// Zadanie 19.12.2022
/*Random r = new Random();
int[] T = new int[30];
T[0] = r.Next(0, 10);
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(0, 10);
    Console.Write(T[i] + " ");
}
Console.WriteLine("\n\n");
for (int i = 0; i < T.Length - 1; i++)
{
    if (T[i] == T[i + 1])
    {
        Console.WriteLine($"Rowne liczby to {T[i]} na pozycjach {i}, {i+1}");
    }
}*/









// example
/*for (int i = 1; i < 11; i++)
{
    for (int j = 1; j < 11; j++)
    {
        Console.WriteLine(i * j + "\t");
    }
    Console.WriteLine();
}*/

// Tablice dwuelementowe
/*int[,] M = new int[5, 5];
M[0, 0] = 6;
M[1, 1] = 6;
M[2, 2] = 6;
M[3, 3] = 6;
M[4, 4] = 6;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (i == j)
            M[i, j] = 6;
        Console.Write(M[i,j] + "\t");
    }
    Console.WriteLine();
}*/
/*
int[,] M = new int[,] { 
                        {1, 2, 3}, 
                        {4, 5, 6}, 
                        {7, 8, 9}, 
                        {10, 11, 12}, 
                        {13, 14, 15}, 
                      };
//Console.WriteLine(M.Length);
//Console.WriteLine(M.GetLength(0));
//Console.WriteLine(M.GetLength(1));
for (int i = 0; i < M.GetLength(0); i++)
{
    for (int j = 0; j < M.GetLength(1); j++)
    {
        Console.WriteLine(M[i,j] + "\t");
    }
    Console.WriteLine();
}
*/
/*string bufor;
StreamReader sr = new StreamReader("C:\\1E MF\\tekst.txt");
while (!sr.EndOfStream)
{
    Console.WriteLine(sr.ReadLine());
}*/

// wczytac plik do zmiennej tablicowej
string bufor;
StreamReader sr = new StreamReader("C:\\1E MF\\tekst.txt");
int[] T = new int[8];
int i = 0;
while (!sr.EndOfStream)
{
    bufor = sr.ReadLine();
    T[i] = int.Parse(bufor);
    i++;
}
foreach (int elem in T)
{
    Console.Write(elem + "\t");
}
