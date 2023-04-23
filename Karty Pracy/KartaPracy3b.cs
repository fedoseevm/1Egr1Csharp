// zad 1
Console.WriteLine("Zadanie 1");
Console.WriteLine("Listopad zawiera dni:");
for (int i = 1; i <= 30; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine();

// zad 2
Console.WriteLine("Zadanie 2");
for (int i = 0; i < 10; i++)
    if (i % 2 == 1)
        Console.WriteLine(Math.Pow(i, 2));
Console.WriteLine();

// zad 3
Console.WriteLine("Zadanie 3");
for (int i = 1000; i <= 9999; i++)
    if (i % 379 == 0)
        Console.WriteLine(i);
Console.WriteLine();

// zad 4
Console.WriteLine("Zadanie 4");
for (int i = 100; i <= 999; i++)
    if ((i % 5 == 0) && (i % 6 == 0) || (i % 11 == 0))
        Console.WriteLine(i);
Console.WriteLine();

// zad 5
Console.WriteLine("Zadanie 5");
Console.Write("Ilosc liczb: ");
int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 1; i <= n; i++)
{
    Console.ReadLine();
    suma += i;
}
Console.WriteLine("Suma: " + suma);
Console.WriteLine();

// zad 6
Console.WriteLine("Zadanie 6");
Console.Write("Ilosc liczb: ");
int k = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 0; i <= (k * 2); i += 2)
    suma += i;
Console.WriteLine("Suma: " + suma);
Console.WriteLine();

// zad 7
Console.WriteLine("Zadanie 7");
Console.Write("Ilosc liczb: ");
int m = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 11; i <= (m * 2 + 10); i += 2)
    suma += i;
Console.WriteLine("Suma: " + suma);
Console.WriteLine();

// zad 8
Console.WriteLine("Zadanie 8");
Console.Write("Kwota wejsciowa: ");
double w0 = int.Parse(Console.ReadLine());
Console.Write("Ile lat: ");
int l = int.Parse(Console.ReadLine());
double wartosc = w0;
double kap = 0;
for (int i = 1; i <= l; i++)
{
    kap = wartosc * 0.06;
    wartosc += kap;
}
Console.WriteLine("Wartosc: " + Math.Round(wartosc, 2));
Console.WriteLine();

// zad 9
Console.WriteLine("Zadanie 9");
Console.Write("Ilosc liczb: ");
int n = int.Parse(Console.ReadLine());
int suma = 0;
int temp = 0;
for (int i = 0; i <= n; i++)
    temp = i * 100 + 21;
suma += temp;
Console.WriteLine("Suma: " + suma);
Console.WriteLine();

//  zad 10
Console.WriteLine("Zadanie 10");
for (int i = 1; i < 1000; i++)
    if ((i % 100 == Math.Sqrt(i)) || (i % 10 == Math.Sqrt(i)))
        Console.WriteLine(i + "");
