// funkcje
// typ nazwa()
//{
//    instr
//    return
//}

/*
using System.Collections;

void przywitaj()
{
    Console.WriteLine("Witam Cię");
}
przywitaj();

// funkcja, która zwroci sumę dwuch wpisanych liczb
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int suma(int a, int b)
{
    return (a + b);
}
Console.WriteLine($"{a} + {b} = {suma(a, b)}");
Console.ReadKey();



// funkcja sumuje każdą ilość liczb
int suma2(int[] liczby)
{
    int suma = 0;
    foreach (int item in liczby)
    {
        suma += item;
    }
    return suma;
}
Console.WriteLine(suma2(new int[] { 4, 7, 8, 1, 0 }));
Console.ReadKey();

// funkcja zwracająca wpisany ciąg odwrotnie
string odwrot(string tekst)
{
    char[] charArray = tekst.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}
Console.WriteLine(odwrot("abc1234"));


// funkcja obliczająca 45% z różnicy 2 wpisanych liczb (ma być na plusie)

double proc_45(double x, double y)
{
    return Math.Abs(x - y) * 0.45;
}
double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
Console.WriteLine($"45% od {x} - {y} = {proc_45(x, y)}");

// funkcja zwarająca boola czy liczba jest wielokrotnością 13
bool wielokr_13(double m)
{
    if (m % 13 == 0)
        return true;
    return false;
}
int m = int.Parse(Console.ReadLine());
if (wielokr_13(m))
    Console.WriteLine("Jest");
else
    Console.WriteLine("Nie jest");



// funkcja zwracająca silnię podanej liczby
int silnia(int x)
{
    int siln = 1;
    for (int i = 1; i <= x; i++)
    {
        siln *= i;
    }
    return siln;
}
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{b}! = {silnia(b)}");
*/




using System.Diagnostics;
// REKURENCJA
/*int f1(int n)
{
    Console.WriteLine(n);
    if (n == 0) return 1;
    return f1(n - 1);
}
f1(5);
Console.WriteLine("\n");


void r1(int n)
{
    if (n == 0) return;
    r1(n - 1);
    Console.WriteLine(n);
}
r1(5);
// FIFO VS LIFO
// FIFO - First In Fist Out
// LIFO - Last In Fist Out
Console.WriteLine("\n");
Console.WriteLine("\n");
*/


/*
// silnia za pomocą rekurencji
int silnia1(int n)
{
    if (n == 0) return 1;
    return silnia1(n - 1) * n;
}
Console.WriteLine(silnia1(3));
*/



// funkcja obliczająca sumę n pierwszych liczb iteracyjnie i rekurencyjnie
/*
bool czy_p(int n)
{
    for (int i = 2; i < Math.Sqrt(n) + 1; i++)
        if (n % i == 0)
            return false;
    return true;
}
int suma_i(int n)
{
    int suma = 0;
    for (int i = 1; i <= n; i++)
    {
        suma += i;
    }
    return suma;
}
Console.WriteLine("Iteracyjnie (petla for)" + suma_i(5));
Console.WriteLine("\n");
int suma_r(int n)
{
    if (n == 0) return 0;
    return suma_r(n - 1) + n;
}
Console.WriteLine("Rekurencyjnie " + suma_r(5));
Console.WriteLine("\n");
*/


/*
// Fibonacci iteracyjnie i rekurencyjnie
Stopwatch time = new Stopwatch();
int liczba = 7;
int fibon_i(int n)
{
    int a = 0;
    int b = 1;
    int temp;
    if (n == 0) return a;
    if (n == 1) return b;
    for (int i = 0; i < n; i++)
    {
        temp = a;
        a = b;
        b += temp;
    }
    return a;
}
time.Start();
Console.WriteLine(fibon_i(liczba));
time.Stop();
Console.WriteLine(time.ElapsedTicks);
time.Reset();

int fibon_r(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    return fibon_r(n - 1) + fibon_r(n - 2);
}
time.Start();
Console.WriteLine(fibon_r(liczba));
time.Stop();
Console.WriteLine(time.ElapsedTicks);
*/

Random r = new Random();
int reku1(int n)
{
    // oblicz dla 5 12 16 21 75
    int w;
    if (n == 1) return 1;
    w = reku1(n / 2);
    if (n % 2 == 0)
        w *= 2;
    else
        w *= 3;
    return w;
}
Console.WriteLine($"reku1({5}) = {reku1(5)}");
Console.WriteLine($"reku1({12}) = {reku1(12)}");
Console.WriteLine($"reku1({16}) = {reku1(16)}");
Console.WriteLine($"reku1({21}) = {reku1(21)}");
Console.WriteLine($"reku1({75}) = {reku1(75)}");
int m = r.Next(22, 75);
Console.WriteLine($"reku1({m}) = {reku1(m)}");
Console.ReadKey();
Console.WriteLine("\n");

int reku2(int n)
{
    // oblicz dla 5 7 8 11
    int w;
    if (n == 3) return 1;
    w = reku2(n - 1);
    if (n % 2 == 1)
        w++;
    else
        w *= 2;
    return w;
}
Console.WriteLine($"reku2({5}) = {reku2(5)}");
Console.WriteLine($"reku2({7}) = {reku2(7)}");
Console.WriteLine($"reku2({8}) = {reku2(8)}");
Console.WriteLine($"reku2({11}) = {reku2(11)}");
int a = r.Next(12, 20);
Console.WriteLine($"reku2({a}) = {reku2(a)}");
Console.ReadKey();
Console.WriteLine("\n");

int reku3(int n)
{
    //oblicz dla 4 5 7 11
    int w;
    if (n == 1) return 0;
    w = reku3(n - 1);
    if (n % 3 == 0)
        w++;
    if (n % 3 == 1)
        w += 2;
    if (n % 3 == 2)
        w *= 3;
    return w;
}
Console.WriteLine($"reku3({4}) = {reku3(4)}");
Console.WriteLine($"reku3({5}) = {reku3(5)}");
Console.WriteLine($"reku3({7}) = {reku3(7)}");
Console.WriteLine($"reku3({11}) = {reku3(11)}");
int b = r.Next(12, 20);
Console.WriteLine($"reku3({a}) = {reku3(a)}");
Console.ReadKey();
Console.WriteLine("\n");

int reku4(int n)
{
    //oblicz dla 9 13
    int w;
    if (n == 1) return 0;
    w = reku4((n - 1) * 2 - n);
    if (n % 2 == 1)
        w++;
    if (n % 3 > 0)
        w += 2;
    return w;
}
Console.WriteLine($"reku4({9}) = {reku4(9)}");
Console.WriteLine($"reku4({13}) = {reku4(23)}");
int c = r.Next(14, 25);
if (c % 2 == 0)
    c++;
Console.WriteLine($"reku4({c}) = {reku4(c)}");
