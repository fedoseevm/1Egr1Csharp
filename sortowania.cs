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





// QuickSort Hoare
List<int> quicksort_hoare(List<int> T, int left, int right)
{
    int i = left;
    int j = right;
    int pivot = T[(left + right) / 2];
    while (i <= j)
    {
        while (T[i] < pivot)
            i++;
        while (T[j] > pivot)
            j--;
        if (i <= j)
        {
            int temp = T[i];
            T[i] = T[j];
            T[j] = temp;
            i++;
            j--;
        }
    }
    if (left < j)
        T = quicksort_hoare(T, left, j);
    if (right > i)
        T = quicksort_hoare(T, i, right);
    return T;
}

Random r = new Random();
List<int> T = new List<int>();
for (int i = 0; i < 10; i++)
{
    T.Add(r.Next(0,10));
    Console.Write(T[i] + " ");
}
Console.WriteLine();
quicksort_hoare(T, 0, T.Count - 1);
for (int i = 0; i < 10; i++)
    Console.Write(T[i] + " ");
Console.WriteLine("\n");
Console.ReadKey();



// QuickSort Lomuto
List<int> quicksort_lomuto(List<int> L, int left, int right)
{
    int pivot = L[right];
    int i = left;
    for (int k = left; k < right; k++)
        if (L[k] <= pivot)
        {
            int temp = L[k];
            L[k] = L[i];
            L[i] = temp;
            i++;
        }
    int temp1 = L[i];
    L[i] = L[right];
    L[right] = temp1;
    if (left < i - 1)
        T = quicksort_lomuto(L, left, i - 1);
    if (right > i + 1)
        T = quicksort_lomuto(L, i + 1, right);
    return T;
}


List<int> L = new List<int>();
for (int i = 0; i < 10; i++)
{
    L.Add(r.Next(0, 10));
    Console.Write(L[i] + " ");
}
Console.WriteLine();
quicksort_hoare(L, 0, L.Count - 1);
for (int i = 0; i < 10; i++)
    Console.Write(L[i] + " ");
