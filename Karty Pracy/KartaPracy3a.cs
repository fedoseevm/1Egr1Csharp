// zad 1
/*int n = int.Parse(Console.ReadLine());
for (int i = 1; i <=n; i++)
{
    Console.Write("*-|");
}*/

// Tabelka mnozenia
/*
for (int i = 1; i<11; i++)
{
    for (int j = 1; j < 11; j++)
    {
        Console.Write(i * j + "\t");
    }
    Console.WriteLine();
}*/


/*
*
**
***
****

****
***
**
*
   *
  **
 ***
****

****
 ***
  **
   *
*/


// drzewo

/*int n = int.Parse(Console.ReadLine());
for (int i = 0; i <= n; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();

// drzewo odwrotne

for (int i = 0; i <= n; i++)
{
    for (int j = 0; j < n - i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


for (int i = 1; i <= n; i++)
{
    for (int j = 0; j < n - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = n - i; k < n; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();

//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
for (int i = 1; i <= n; i++)
{
    for (int j = 0; j <= n - i; j++)
    {
        Console.Write("*");
    }
    for (int k = n - i; k < n; k++)
    {
        Console.Write(" ");
    }
    Console.WriteLine();
}*/

// zad 2
/*int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.Write("*")
}*/

/*
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"({i},{j})");
    }
    Console.WriteLine();
}
Console.WriteLine();

// zad 6
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i + j == n - 1)     Console.Write("?");
        else if (i - j == 0)    Console.Write("*");
        else                    Console.Write(" ");
    }
    Console.WriteLine();
}
*/

// zad 7
/*int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == 0 || i == n-1 || j == 0 || j == n-1 || i == n / 2 && j == n / 2)
            Console.Write("*");
        else Console.Write(" ");
    }
    Console.WriteLine();
}
*/

// zad 5
/*
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (j == n/2)       Console.Write("*" + " ");
        else if (i == n/2)  Console.Write("-" + " ");
        else                    Console.Write(" " + " ");
    }
    Console.WriteLine();
}
*/

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if ((Math.Abs(i - j) == n / 2) || (i + j == n / 2) || (i + j == 3 * n / 2 - 1))
            Console.Write("*");
        else Console.Write("-");
    }
    Console.WriteLine();
}
