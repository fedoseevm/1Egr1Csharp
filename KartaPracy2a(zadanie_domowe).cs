// zad 1

Console.WriteLine("Podaj 2 liczby całkowite: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if ((a + b) % 2 == 0)
{
    Console.WriteLine("suma jest liczbą parzystą");
}
else
{
    Console.WriteLine("suma nie jest liczbą parzystą");
}

// zad 2

Console.WriteLine("Podaj 2 liczby całkowite: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (((a + b) / 2) > (Math.Pow(a * b, 0.5)))
{
    Console.WriteLine("średnia arytmetyczna jest większa od jej średniej geomentrycznej");
}
else
{
    Console.WriteLine("średnia arytmetyczna nie jest większa od jej średniej geonetrycznej");
}

// zad 3

Console.WriteLine("Podaj 3 liczbę całkowite:");
int k = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
if ((k == m) && (k == l) && (l == m))
{
    Console.WriteLine("Wszystkie liczby są równe");
}
if ((k == l) && !(k == m) && !(l == m))
{
    Console.Write("k = l = ");
    Console.WriteLine(k);
}
if ((k == m) && !(k == l) && !(l == m))
{
    Console.Write("k = m = ");
    Console.WriteLine(m);
}
if ((l == m) && !(k == m) && !(l == k))
{
    Console.Write("l = m = ");
    Console.WriteLine(l);
}

// zad 4

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
if ((a < b) && (a < c) && (a < d))
{
    Console.WriteLine(a);
}
if ((b < a) && (b < c) && (b < d))
{
    Console.WriteLine(b);
}
if ((c < a) && (c < b) && (c < d))
{
    Console.WriteLine(c);
}
if ((d < a) && (d < b) && (d < c))
{
    Console.WriteLine(d);
}

// zad 5

Console.WriteLine("Podaj 3 długości boków trójkąta");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if (((a + b) > c) && ((a + c) > b) && ((b + c) > a))
{
    Console.WriteLine("Spełniają");
}
else
{
    Console.WriteLine("Nie spełnia");
}    

// zad 6

Console.WriteLine("Podaj 3 długości boków trójkąta");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if (((a+b)>c) && ((a+c)>b) && ((b+c)>a))
{
    int max = a;
    int b1 = b;
    int b2 = c;
    if (max < b)
    {
        b1 = a;
    }
    if (max < c)
    {
        max = c;
        b1 = a;
        b2 = b;
    }
    if (Math.Pow(max, 2) == Math.Pow(b1, 2) + Math.Pow(b2, 2))
        {
        Console.WriteLine("Trójkąt prostokątny");
    }
    if (Math.Pow(max, 2) < Math.Pow(b1, 2) + Math.Pow(b2, 2))
            {
        Console.WriteLine("Trójkąt ostrokątny");
    }
    if (Math.Pow(max, 2) > Math.Pow(b1, 2) + Math.Pow(b2, 2))
    {
        Console.WriteLine("Trójkąt rozwartokątny");
    }
}
else
{
    Console.WriteLine("To nie jest trójkąt");
}
