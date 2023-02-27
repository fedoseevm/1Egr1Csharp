using System.Collections;

/*
namespace Enuma
{
    enum PoryRoku { Zima, Wiosna, Lato, Jesien };
    class Antoni
    {
        public static void Main()
        {
            Console.WriteLine(PoryRoku.Lato);
            Console.ReadKey();
        }
    }
}
*/

/*
ArrayList A = new ArrayList() { 4, 78, 12, 0, 13 };
A.Add(21);
A.Add(40);

foreach (int x in A)
{
    Console.Write(x + " ");
}
Console.WriteLine("\n");

if (A.Contains(12))
{
    A.Insert(A.IndexOf(12), 0);
}

foreach (int x in A)
{
    Console.Write(x + " ");
}
Console.WriteLine("\n");
*/

int[] T = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
if (Array.Exists(T, x => x == 9))       // zamiast x moze byc cokolwiek
{

}




string[] S = new string[] { "Artiom", "Maciej", "Daniel", "Antonio" };
if (Array.Exists(S, slowo => slowo.StartsWith("A")))
{
    Console.WriteLine("Sa imiona na A");
}

Array.Sort(S);
Array.Reverse(S);
foreach (var item in S)
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");



// TABLICA DWUWYMIAROWA POWTORKA
int[,] M = new int[3, 2];
M[0, 0] = 3;
M[2, 1] = 4;

for (int i = 0; i < M.GetLength(0); i++)
{
    for (int j = 0; j < M.GetLength(1); j++)
    {
        Console.Write(M[i,j] + "\t");
    }
    Console.WriteLine("\n");
}
