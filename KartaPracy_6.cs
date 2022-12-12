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
/*int podstawa = 0;
int k = 0;
int first = 0;
for (int i = 99; i > 9; i++)
{
    if (i % 7 == 0)
    {
        podstawa = i;
        break;
    }
}
Console.WriteLine(podstawa);
for (int i = 1000; i < podstawa; i++)
    if (i % podstawa == 0)
    {
        first = i;
        break;
    }
for (int i = first; i <= 9999; i += podstawa)
{
    k++;
}
Console.WriteLine(k);
*/

//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

// zad 4
/*int ilosc = 0;
int cd = 0;
int cj = 0;
for (int i = 10; i < 100; i++)
{
    cd = i / 10;
    cj = i % 10;
    if (cd >= 2 * cj)
    {
        ilosc += 1;
    }
}
Console.WriteLine(ilosc);
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

// zad 16
