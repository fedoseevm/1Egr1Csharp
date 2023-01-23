// Tablice dwuelementowe
/*int[,] M = new int[5, 5];
M[0, 0] = 6;
M[1, 1] = 6;
M[2, 2] = 6;
M[3, 3] = 6;
M[4, 4] = 6;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (i == j)
            M[i, j] = 6;
        Console.Write(M[i,j] + "\t");
    }
    Console.WriteLine();
}*/
/*
int[,] M = new int[,] { 
                        {1, 2, 3}, 
                        {4, 5, 6}, 
                        {7, 8, 9}, 
                        {10, 11, 12}, 
                        {13, 14, 15}, 
                      };
//Console.WriteLine(M.Length);
//Console.WriteLine(M.GetLength(0));
//Console.WriteLine(M.GetLength(1));
for (int i = 0; i < M.GetLength(0); i++)
{
    for (int j = 0; j < M.GetLength(1); j++)
    {
        Console.WriteLine(M[i,j] + "\t");
    }
    Console.WriteLine();
}
*/
/*string bufor;
StreamReader sr = new StreamReader("C:\\1E MF\\tekst.txt");
while (!sr.EndOfStream)
{
    Console.WriteLine(sr.ReadLine());
}*/

// wczytac plik do zmiennej tablicowej
string bufor;
StreamReader sr = new StreamReader("C:\\1E MF\\tekst.txt");
int[] T = new int[8];
int i = 0;
while (!sr.EndOfStream)
{
    bufor = sr.ReadLine();
    T[i] = int.Parse(bufor);
    i++;
}
foreach (int elem in T)
{
    Console.Write(elem + "\t");
}
