// Zadanie 1

int x = int.Parse(Console.ReadLine());
int max = 0;
while (x > 0)
{
    if (x % 10 > max)
        max = x % 10;
    x = x / 10;
}
Console.WriteLine(max);


// Zadanie 2

int reku(int x)
{
    if (x == 1) return 1;
    if (x == 2) return 3;
    if (x == 3) return 5;
    return reku(x - 1) + reku(x - 2) + reku(x - 3);
}

Console.Write("Podaj ilosc elementow w ciagu: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
for (int i = 1; i <= n; i++)
    Console.Write(reku(i) + " ");

// Zadanie 3

Random r = new Random();
string path = @"C:\Users\uczen\MF 1E\Csharp\spr_24_04\boki.txt";
using (StreamWriter sw = new StreamWriter(path))
    for (int i = 0; i < 15; i++)
        sw.WriteLine(r.Next(1, 10) + " " + r.Next(1, 10));
List<int> liczby = new List<int>();
using (StreamReader sr = new StreamReader(path))
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        string[] wyn = line.Split();
        liczby.Add(Convert.ToInt32(wyn[0]) * Convert.ToInt32(wyn[1]));
    }
int k = 1;
foreach (int para in liczby)
{
    Console.WriteLine($"Pole {k} = {para}");
    k++;
}
