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
Console.Write("Podaj ilosc elementow: ");
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
int k = 0;
int[] A = new int[n];
for (int i = 0; i < n; i++)
{
    A[i] = int.Parse(Console.ReadLine());
    if (A[i] > max)
        max = A[i];
}
for (int i = 0; i < n; i++)
    if (A[i] == max)
        k++;
Console.WriteLine("Max Value: " + max + " ");
Console.Write(k);*/

int n = int.Parse(Console.ReadLine());
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
Console.Write("Max Value Count: " + k);
