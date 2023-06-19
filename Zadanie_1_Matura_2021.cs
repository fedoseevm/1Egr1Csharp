//Przykład:
//Cyfrowym dopełnieniem liczby 2021 jest liczba 7978

// Zad 1.1
int maxik = 0;
int minik = 10000;
int max_n = 0;
int min_n = 0;
for (int i = 1000; i < 9000; i++)
{
    int d = 9999 - i;
    int z = Math.Abs(i - d);
    if (z > maxik)
    {
        maxik = z;
        max_n = i;
    }
    if (z < minik)
    {
        minik = z;
        min_n = i;
    }
}
Console.WriteLine($"Najmniejsza wartosc bezwzgledna przy n = {min_n}");
Console.WriteLine($"Najwieksza wartosc bezwzgledna przy n = {max_n}");


// Zadanie 1.2
int n = int.Parse(Console.ReadLine());
int temp = n;
int cyfra_znacz = 0;
int k = 0;
int d = 0;
if (n > 0)
{
    while (temp > 0)
    {
        cyfra_znacz = temp % 10;
        temp = temp / 10;
        k++;
    }
    if (cyfra_znacz > 0 && cyfra_znacz < 9)
    {
        int potega = 1;
        for (int i = 0; i < k; i++)
            potega *= 10;
        d = (potega - 1) - n;
    }
}
Console.WriteLine(d);
