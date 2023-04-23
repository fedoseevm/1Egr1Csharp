// Matura Zadanie 4
bool czyp(int x)
{
    for (int i = 2; i <= Math.Sqrt(x); i++)
        if (x % i == 0)
            return false;
    return true;
}

string odwrot(string x)
{
    char[] T = x.ToCharArray();
    Array.Reverse(T);
    string wyn = new string(T);
    return wyn;
}

// 4.1
List<int> L1 = new List<int>();
using (StreamReader sr = new StreamReader(@"D:\Microsoft Visual Studio\Projects\Csharp\Zad_4_matura\liczby.txt"))
    while (!sr.EndOfStream)
        L1.Add(int.Parse(sr.ReadLine()));
using (StreamWriter sw = new StreamWriter(@"D:\Microsoft Visual Studio\Projects\Csharp\Zad_4_matura\wynik4_1.txt"))
    foreach (int liczba in L1)
        if (czyp(liczba) && liczba >= 100 && liczba <= 5000)
            sw.WriteLine(liczba);
            
// 4.2
List<string> P1 = new List<string>();
using (StreamReader sr = new StreamReader(@"D:\Microsoft Visual Studio\Projects\Csharp\Zad_4_matura\pierwsze.txt"))
    while (!sr.EndOfStream)
        P1.Add(sr.ReadLine());
using (StreamWriter sw = new StreamWriter(@"D:\Microsoft Visual Studio\Projects\Csharp\Zad_4_matura\wynik4_2.txt"))
    foreach (string liczba in P1)
        if (czyp(Convert.ToInt32(odwrot(liczba))))
            sw.WriteLine(liczba);
            
// 4.3
int waga(int x)
{
    int waga = 0;
    while (x / 10 > 0)
    {
        waga = 0;
        while (x > 0)
        {
            waga += x % 10;
            x /= 10;
        }
        x = waga;
    }
    return waga;
}
List<int> P2 = new List<int>();
using (StreamReader sr = new StreamReader(@"D:\Microsoft Visual Studio\Projects\Csharp\Zad_4_matura\pierwsze.txt"))
    while (!sr.EndOfStream)
        P2.Add(int.Parse(sr.ReadLine()));
using (StreamWriter sw = new StreamWriter(@"D:\Microsoft Visual Studio\Projects\Csharp\Zad_4_matura\wynik4_3.txt"))
    foreach (int liczba in P2)
        if (waga(liczba) == 1)
            sw.WriteLine(liczba);
