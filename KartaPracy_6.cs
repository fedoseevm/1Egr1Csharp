// zad 1
/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

// arytmetyczny czy geometryczny
if (b - a == c - b) Console.WriteLine("jest arytmetyczny");
else if (b / a == c / b) Console.WriteLine("jest geometryczny");

if ( a < b) Console.WriteLine("jest rosnacy");
if (a > b) Console.WriteLine("jest malejacy");
*/

// zad 2 
/*int suma = 0;
for (int i = 104; i <= 999; i += 16)
{
    suma += i;
}
Console.WriteLine(suma);
*/

// zad 3
/*int wielokr = 0;
int k = 0;
int pierwsza_podzielna = 0;
for (int i = 99; i > 9; i--)
{
    if (i % 7 == 0)
    {
        wielokr = i;
        break;
    }
}
Console.Write("Wielokrotnosc: " + wielokr);
for (int i = 1000; i < 1000 + wielokr; i++)
    if (i % wielokr == 0)
    {
        pierwsza_podzielna = i;
        break;
    }
for (int i = pierwsza_podzielna; i <= 9999; i += wielokr)
{
    k++;
}
Console.WriteLine();
Console.Write("Ilosc liczb spelniajacych warunki: " + k);
*/

// zad 4
/*int ilosc = 0;
int cd;
int cj;
for (int i = 10; i < 100; i++)
{
    cd = i / 10;
    cj = i % 10;
    if (cd >= 2 * cj)
    {
        ilosc++;
    }
}
Console.WriteLine(ilosc);
*/

// zad 5
/*int ilosc = 0;
int suma = 0;
int cs;
int cd;
int cj;
for (int i = 100; i < 1000; i++)
{
    cs = i / 100;
    cd = i % 100 / 10;
    cj = i % 10;
    if (cs > cd + cj)
    {
        suma += i;
        ilosc++;
    }
}
Console.WriteLine("Ilosc: " + ilosc);
Console.WriteLine("Suma: " + suma);
*/

// zad 8
/*int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 1; i <= n; i++)
{
    suma = suma + (3 * i - 1) * Convert.ToInt16(Math.Pow(-1, i-1));
}
Console.WriteLine(suma);
*/


// zad 10
/*
int n = int.Parse(Console.ReadLine());
int suma = 0;
int wynik = 1;
for (int i = 1; i <= n; i++)
{
    wynik = 1;
    for (int j = 1; j <= i; j++)
    {
        wynik = wynik * j;
    }
    suma += wynik;
}
Console.WriteLine(suma);
*/

// zad 11
/*int n = int.Parse(Console.ReadLine());
double suma = 0;
for (int i = 1; i <= n; i++)
{
    suma = suma + (2 * i  - 1)/(Math.Pow(i, 2));
}
Console.WriteLine(suma);
*/
