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

int n = int.Parse(Console.ReadLine());
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

// zad 2
/*int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.Write("*")
}*/


