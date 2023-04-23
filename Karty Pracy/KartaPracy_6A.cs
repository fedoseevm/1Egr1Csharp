using System.ComponentModel;

// Funkcje
bool czy_pierwsza(int x)
{
    bool czy_p = true;
    for (int i = 2; i < Convert.ToInt16(Math.Pow(x, 0.5)) + 1; i++)
    {
        if (x % i == 0)
        {
            czy_p = false;
            break;
        }
    }
    if (czy_p && x != 1)  return true;
    else        return false;
}


// zad 1
/*int x = int.Parse(Console.ReadLine());
int suma = 0;
while (x > 0)
{
    suma += x % 10;
    x = x / 10;
}
Console.WriteLine(suma);*/

// zad 2
/*int n = int.Parse(Console.ReadLine());
if (czy_pierwsza(n))
    Console.WriteLine("Liczba piewsza");
else
    Console.WriteLine("Liczba nie jest pierwsza");*/

// zad 3
/*int n = int.Parse(Console.ReadLine());
int suma_dzielnikow = 0;
for (int i = 1; i < n / 2 + 1; i++)
{
    if (n % i == 0)
        suma_dzielnikow += i;
}
if (suma_dzielnikow == n)   Console.WriteLine("Liczba jest doskonala");
else                        Console.WriteLine("Liczba nie jest doskonala");*/

// zad 4
/*int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int temp;
while (b > 0)
{
    temp = x;
    x = y;
    y = temp % y;
}
if (x == 1) Console.WriteLine($"Liczby sa wzglednie pierwsze");
else Console.WriteLine($"Liczby nie sa wzglednie pierwsze");*/

// zad 5
//List<int> T = new List<int>();
/*int m = int.Parse(Console.ReadLine());
for (int i = 10; i < 20; i++)
{
    int a = m;
    int b = i;
    int temp;
    while (b > 0)
    {
        temp = a;
        a = b;
        b = temp % b;
    }
    if (a == 1)
        {
            Console.Write(i + " ");
        }
}*/

// zad 6
/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int x = a;
int y = b;
int temp;
while (y > 0)
{
    temp = x;
    x = y;
    y = temp % y;
}
if (x == 1) Console.WriteLine("Nie da sie skrocic");
else
{
    Console.WriteLine($"{a}/{b} = {a/x}/{b/x}");
}
*/

// zad 7
/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int czynnik = a / b;
if (a % b == 0)
    Console.WriteLine($"{a}/{b} = {czynnik}");
else
{
    int c = a - czynnik * b;
    int x = a;
    int y = b;
    int temp;
    while (y > 0)
    {
        temp = x;
        x = y;
        y = temp % y;
    }
    if (x == 1) Console.WriteLine("Nie da sie skrocic");
    else
    {
        Console.WriteLine($"{a}/{b} = {czynnik}*({c / x}/{b / x})");
    }
}*/
