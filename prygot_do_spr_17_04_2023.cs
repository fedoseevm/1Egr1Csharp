// ODCZYTYWANIE PLIKOW
//StreamReader sr = new StreamReader("D:\\Microsoft Visual Studio\\Projects\\Csharp\\plik.txt");
//while (!EndOfStream)
//{

//}

// Zagadnienia na sprawdzian

// 1. Funkcje

// 1.1 - Napisz funkcje która zwraca sume cyfr podaniej liczby

int liczba = int.Parse(Console.ReadLine());
int suma_cyfr(int x)
{
    string liczba = Convert.ToString(x);
    int suma = 0;
    foreach (char cyfra in liczba)
    {
        suma += Convert.ToInt32(cyfra.ToString());
    }
    return suma;
    //while (x > 0)
    //{
    //    suma += x % 10;
    //    x /= 10;
    //}
    //return suma;
}
Console.WriteLine($"Suma cyfr: {suma_cyfr(liczba)}");
Console.ReadKey();
Console.WriteLine("\n");


// 1.2 - Napisz funkcje, która zwraca odwrócony do wprowadzonego napis i usuwa pierwsza i ostatnia litere

string napis = Console.ReadLine();
string odwrot(string x)
{
    char[] T = napis.ToCharArray();
    Array.Reverse(T);
    string A = new string(T);
    string wynik = A.Remove(0, 1);
    //int lastIdx = wynik.LastIndexOf(wynik[wynik.Length - 1]);
    wynik = wynik.Remove(wynik.LastIndexOf(wynik[wynik.Length - 1]), 1);
    return wynik;
}
Console.WriteLine($"{napis} <> {odwrot(napis)}");
Console.ReadKey();
Console.WriteLine("\n");


// 1.3 - Napisz funkcje, która wypisuje łańcuch połówek wpisanej liczby, aż do 1. Np po wpisaniu 30 otrzymujemy 15-7-3-1. Rozumiecie? :)

int n = int.Parse(Console.ReadLine());
List<string> polowki(int x)
{
    List<string> l = new List<string>();
    while (x > 1)
    {
        l.Add(Convert.ToString(x / 2));
        l.Add("-");
        x /= 2;
    }
    l.RemoveAt(l.LastIndexOf("-"));
    return l;
}
foreach (string x in polowki(n))
    Console.Write(x);
Console.ReadKey();
Console.WriteLine("\n");


// 2. Rekurencja

// 2.1 - Napisz rekurencyjnie n liczb: 3,5,7,9,11...

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
Console.ReadKey();


// 3. Pliki

// 3.1 Stwórz plik z dzisiejszą datą

//// Na lekcji:
//StreamWriter SW = new StreamWriter(@"C:\Users\uczen\MF 1E\Csharp\data.txt");
//SW.WriteLine(DateTime.Now);
//SW.Flush();
//SW.Close();




// LEPIEJ robic jak ponizej!
string path = @"D:\Microsoft Visual Studio\Projects\Csharp\spr_17_04\wynik_3-1.txt";
if (File.Exists(path))
    File.Delete(path);

using (StreamWriter Data = new StreamWriter(path, true))
    Data.WriteLine(DateTime.Now);


// 3.2 Zapisz do pliku 10 losowych liczb dwucyfrowych. Odczytaj ten plik i wypisz największą z liczb

//// Rozkomentowac, jesli w wierszu 170 bedzie TRUE
//if (File.Exists(@"D:\Microsoft Visual Studio\Projects\Csharp\spr_17_04\wynik_3-2.txt"))
//    File.Delete(@"D:\Microsoft Visual Studio\Projects\Csharp\spr_17_04\wynik_3-2.txt");

Random r = new Random();
using (StreamWriter plik1 = new StreamWriter(@"D:\Microsoft Visual Studio\Projects\Csharp\spr_17_04\wynik_3-2.txt", false))
    for (int i = 0; i < 10; i++)
        plik1.WriteLine(r.Next(10, 100));

List<int> L10 = new List<int>();
using (StreamReader sr1 = new StreamReader(@"D:\Microsoft Visual Studio\Projects\Csharp\spr_17_04\wynik_3-2.txt"))
    while (!sr1.EndOfStream)
        L10.Add(int.Parse(sr1.ReadLine()));
Console.WriteLine($"Najwieksza liczba: {L10.Max()}");
Console.ReadKey();

// 3.3 Zapisz do pliku 100 losowych liczb trzycyfrowych. Odczytaj ten plik i wypisz wszystkie liczby-palindromy, np 242 itp.
bool czy_palindrom(string slowo)
{
    char[] chary = slowo.ToCharArray();
    Array.Reverse(chary);
    string odwrot = new(chary);
    if (slowo == odwrot)
        return true;
    return false;
}

using (StreamWriter plik2 = new StreamWriter(@"D:\Microsoft Visual Studio\Projects\Csharp\spr_17_04\wynik_3-3.txt", false))
    for (int i = 0; i < 100; i++)
        plik2.WriteLine(r.Next(100, 1000));

List<string> liczby = new List<string>();
using (StreamReader sr2 = new StreamReader(@"D:\Microsoft Visual Studio\Projects\Csharp\spr_17_04\wynik_3-3.txt"))
    while (!sr2.EndOfStream)
        liczby.Add(sr2.ReadLine());
List<string> palindroms = new List<string>();
foreach (string liczba in liczby)
    if (czy_palindrom(liczba))
        palindroms.Add(liczba);
Console.Write("Palindromy: ");
foreach (string wynik in palindroms)
    Console.Write(wynik + "  ");

Console.ReadKey();
Console.WriteLine("\n");


// Dzialania na STRINGach
// 1 - odwracanie napisu
string napis1 = Console.ReadLine();
for (int i = napis1.Length - 1; i >= 0; i--)
{
    Console.Write(napis1[i]);
}

Console.ReadKey();
Console.WriteLine("\n");

// 2 - usuwanie duplikatów
string napis2 = Console.ReadLine();
string bezduplikatow = new string(napis2.Distinct().ToArray());
Console.WriteLine(bezduplikatow);

Console.ReadKey();
Console.WriteLine("\n");

// 3 - wyliczanie powtórzeń
string napis3 = Console.ReadLine();
int suma = 0;
for (int i = 0; i < napis3.Length - 1; i++)
{
    if (napis3[i] == napis3[i + 1])
    {
        suma++;
    }
}
Console.WriteLine(suma);

Console.ReadKey();
Console.WriteLine("\n");

// 4 - anagramy 
string napis4 = Console.ReadLine();
string anagram = Console.ReadLine();
napis4 = new string(napis4.OrderBy(x => x).ToArray());
anagram = new string(anagram.OrderBy(x => x).ToArray());
if (napis4 == anagram) Console.WriteLine("anagram");
else Console.WriteLine("nie");

//5 - kolejność alfabetyczna
string alfabet = Console.ReadLine();
alfabet = new string(alfabet.OrderBy(a => a).ToArray());
Console.WriteLine(alfabet);

//6 - palindrom 
string napis6 = Console.ReadLine();
char[] charArray = napis6.ToCharArray();
Array.Reverse(charArray);
string odwrot = new string(charArray);

//7 - usuwanie spacji
string napis7 = Console.ReadLine();
string bezspacji = new string(napis7.Replace(" ", ""));

Console.WriteLine(bezspacji);
