// SORTOWANIE
Random r = new Random();
int n = 8;
int[] SB = new int[n];
for (int i = 0; i < SB.Length; i++)
{
    SB[i] = r.Next(0, 100);
    Console.Write(SB[i] + " ");
}
int temp;

// Bąbelkowe
/*
for (int i = n - 1; i >= 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        if (SB[j + 1] < SB[j])
        {
            temp = SB[j];
            SB[j] = SB[j + 1];
            SB[j + 1] = temp;
        }
    }
}
Console.WriteLine("\n");
foreach (int item in SB)
    Console.Write(item + " ");
*/

// PONIZEJ BEDZIE INNA WERSJA
/*
List<int> przejscie_sort(List<int> list)
{
    int temp;
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i + 1] < list[i])
        {
            temp = list[i];
            list[i] = list[i + 1];
            list[i + 1] = temp;
        }

    }
}
*/

// insertion
int j;
for (int i = 1; i < n; i++)
{
    temp = SB[i];
    j = i - 1;
    while (j >= 0 && SB[j] > temp)
    {
        SB[j + 1] = SB[j];
        j--;
    }
    SB[j] = temp;

    //for (int j = i - 1; j >= 0; j--)
    //{
    //    if (SB[j] > temp)
    //    {

    //    }
    //}
}


// bucket
