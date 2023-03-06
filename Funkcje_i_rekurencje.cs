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





// REKURENCJA
/*int f1(int n)
{
    Console.WriteLine(n);
    if (n == 0) return 1;
    return f1(n - 1);
}
f1(5);*/

/*
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


// silnia za pomocą rekurencji
int silnia1(int n)
{
    if (n == 0) return 1;
    return silnia1(n - 1) * n;
}
Console.WriteLine(silnia1(3));

// funkcja obliczająca sumę n pierwszych liczb iteracyjnie i rekurencyjnie
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



// Fibonacci iteracyjnie i rekurencyjnie
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
Console.WriteLine(fibon_i(5));

int fibon_r(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    return fibon_r(n - 1) + fibon_r(n - 2);
}
Console.WriteLine(fibon_r(5));
