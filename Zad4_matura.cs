// ZADANIE 4
using System.Collections;
//string[] liczby = System.IO.File.ReadAllLines(@"C:\Users\uczen\MF 1E\Csharp\C# Zadanie\liczby.txt");
StreamReader sr = new StreamReader("C:\\Users\\uczen\\MF 1E\\Csharp\\C# Zadanie\\liczby.txt");
StreamWriter wynik1 = new(@"C:\Users\uczen\MF 1E\Csharp\C# Zadanie\wyniki4_1.txt");
StreamWriter wynik2 = new(@"C:\Users\uczen\MF 1E\Csharp\C# Zadanie\wyniki4_2.txt");
ArrayList Liczby = new ArrayList();
while (!sr.EndOfStream)
{
    Liczby.Add(int.Parse(sr.ReadLine()));
    //wynik.WriteLine(sr.ReadLine());
}
//foreach (int elem in Liczby)
//{
//    Console.Write(elem + "\t");
//}

StreamReader ab = new StreamReader("C:\\Users\\uczen\\MF 1E\\Csharp\\C# Zadanie\\pierwsze.txt");
ArrayList Pierwsze = new ArrayList();
while (!ab.EndOfStream)
{
    Pierwsze.Add(Convert.ToString(ab.ReadLine()));
}




// 4.1
wynik1.WriteLine("Zadanie 4.1\n");
bool czyP(int x)
{
    for (int i = 2; i < Math.Sqrt(x) + 1; i++)
        if (x % i == 0)
    return false;
    return true;
}

foreach (int item in Liczby)
{
    if (item >= 100 && item <= 5000 && czyP(item))
        wynik1.WriteLine(item);
}
wynik1.Close();


// 4.2
wynik2.WriteLine("Zadanie 4.2\n");
foreach (string item in Pierwsze)
{
    char[] odwrot = item.ToArray();
    Array.Reverse(odwrot);
    if (czyP(int.Parse(item)) && czyP(int.Parse(string.Join("", odwrot))))
        wynik2.WriteLine(item);
}

wynik2.Close();

// 4.3

int suma_cyfr(int n)
{
    int suma = 0;
    while (n > 0)
    {
        suma += n % 10;
        n /= 10;
    }
    return suma;
}
int waga(int n)
{
    while (n >= 10)
    {
        n = suma_cyfr(n);
    }
    return n;
}

wynik3.WriteLine("Zadanie 4.3\n");
foreach (string pierwsza in Pierwsze)
{
    if (waga(int.Parse(pierwsza)) == 1)
    {
        wynik3.WriteLine(pierwsza);
    }
}

wynik3.Close();
