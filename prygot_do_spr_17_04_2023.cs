// Zagadnienia na sprawdzian

// 1. Funkcje

// 1.1 - Napisz funkcje która zwraca sume cyrf podaniej liczby
/*
int liczba = int.Parse(Console.ReadLine());
int suma_cyfr(int x)
{
    int suma = 0;
    *//*foreach (int cyfra in Convert.ToString(x))
    {
        suma += cyfra;
    }
    return suma;*//*
    while (x > 0)
    {
        suma += x % 10;
        x /= 10;
    }
    return suma;
}
Console.WriteLine($"Suma cyfr: {suma_cyfr(liczba)}");
Console.ReadKey();
Console.WriteLine("\n");

// 1.2 - Napisz funkcje, która zwraca odwrócony do wprowadzonego napis

string napis = Console.ReadLine();
string odwrot(string x)
{
    char[] T = napis.ToCharArray();
    Array.Reverse(T);
    return new String(T);
}
Console.WriteLine($"{napis} <> {odwrot(napis)}");
Console.ReadKey();

// 1.3 - Napisz funkcje, która wypisuje łańcuch połówek wpisanej liczby, aż do 1. Np po wpisaniu 30 otrzymujemy 15-7-3-1. Rozumiecie? :)
int n = int.Parse(Console.ReadLine());
List<int> polowki(int x)
{
    List<int> l = new List<int>();
    while (x > 1)
    {
        l.Add(x / 2);
        x /= 2;
    }
    return l;
}
Console.WriteLine($"połówki liczby {n}: {polowki(n)}");
Console.ReadKey();
*/

// 2. Rekurencja

// 2.1 - Napisz rekurencyjnie n liczb: 3,5,7,9,11...
/*
int a = int.Parse(Console.ReadLine());
int reku1(int x)
{
    if (x == 1)
        return 3;
    return reku1(x - 1) + 2;
}
for (int i = 1; i <= a; i++)
{
    Console.Write(reku1(i) + " ");
}
Console.WriteLine("\n");

// 2.2 - Napisz rekurencyjnie n liczb: 6, 12, 24,48,96...

int reku2(int x)
{
    if (x == 1)
        return 6;
    return reku2(x - 1) * 2;
}
for (int i = 1; i <= a; i++)
{
    Console.Write(reku2(i) + " ");
}
Console.WriteLine("\n");

// 2.3 - Napisz rekurencyjnie n liczb: 1,1,3,5,11,21...

int reku3(int x)
{
    if (x < 3)
        return 1;
    return 2 * reku3(x - 2) + reku3(x - 1);
}
for (int i = 1; i <= a; i++)
    Console.Write(reku3(i) + " ");
Console.WriteLine("\n");

// 2.4 - Napisz rekurencyjnie n liczb: 1,2,-1,3,-4,7,-11,18...

int reku4(int x)
{
    if (x == 1) return 1;
    if (x == 2) return 2;
    return reku4(x - 2) - reku4(x - 1);

}
for (int i = 1; i <= a; i++)
    Console.Write(reku4(i) + " ");
Console.WriteLine("\n");

// 2.5 - Napisz rekurencyjnie n liczb: 1,2,3,0,6,3,-3,21...
int reku5(int x)
{
    if (x == 1) return 1;
    if (x == 2) return 2;
    if (x == 3) return 3;
    return 3 * reku5(x - 3) - reku5(x - 1);
}
for (int i = 1; i <= a; i++)
    Console.Write(reku5(i) + " ");
Console.WriteLine("\n");
*/

// 3. Pliki

// 3.1 Stwórz plik z dzisiejszą datą

StreamWriter SW = new StreamWriter(@"C:\Users\uczen\MF 1E\Csharp\data.txt");
SW.WriteLine(DateTime.Now);
SW.Flush();
SW.Close();
// 3.2 Zapisz do pliku 10 losowych liczb dwucyfrowych. Odczytaj ten plik i wypisz największą z liczb

StreamWriter LD = new StreamWriter(@"C:\Users\uczen\MF 1E\Csharp\10_losowych_dwucyfrowych.txt");
Random r = new Random();
for (int i = 0; i < 10; i++)
    LD.WriteLine(r.Next(10, 100));
LD.Close();

string[] lines = System.IO.File.ReadAllLines(@"C:\Users\uczen\MF 1E\Csharp\10_losowych_dwucyfrowych.txt");
int[] t = new int[10];
int max = 0;
for (int i = 0; i < 10; i++)
    if (t[i] > max)
        max = t[i];
SW.Flush();     //!!!!!!!!!!!!!!!!!!!
LD.WriteLine("\n");
LD.WriteLine($"Maksymalny element: {max}");
LD.Close();

// 3.3 Zapisz do pliku 100 losowych liczb trzycyfrowych. Odczytaj ten plik i wypisz wszystkie liczby-palindromy, np 242 itp.
