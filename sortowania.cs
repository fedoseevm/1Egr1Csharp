Random R = new Random();
int n = 20;
int[] T = new int[n];
for (int i = 0; i < n; i++)
{
    T[i] = R.Next(10, 100);
    Console.Write(T[i] + " ");
}
Console.WriteLine("\n");
Console.WriteLine("\n");


// 1. Bąbelkowe

int[] sort_bubble(int[] T)
{
    int temp;
    for (int i = n - 1; i >= 0; i--)
        for (int j = 0; j < i; j++)
        {
            if (T[j + 1] < T[j])
            {
                temp = T[j];
                T[j] = T[j + 1];
                T[j + 1] = temp;
            }
        }
    return T;
}
sort_bubble(T);


// 2. Przez wybor (selection sort)
// wybieramy najmniejszy i wstawiamy go na poczatek

int[] sort_selection_start(int[] T)
{
    int k;
    int temp;
    for (int i = 0; i < n; i++)
    {
        k = i;
        for (int j = i + 1; j < n; j++)
            if (T[j] < T[k])
                k = j;
        temp = T[i];
        T[i] = T[k];
        T[k] = temp;
    }
    return T;
}
sort_selection_start(T);


// wybieramy najmniejszy i wstawiamy go na koniec

int[] sort_selection_end(int[] T)
{
    int k;
    int temp;
    for (int i = n - 1; i > 0; i--)
    {
        k = i;
        for (int j = 0; j < i; j++)
            if (T[j] < T[k])
                k = j;
        temp = T[k];
        T[k] = T[i];
        T[i] = temp;
    }
    return T;
}
sort_selection_end(T);


// 3. Przez wstawianie (insertion sort)

int[] insert_sort(int[] T)
{
    int j, temp;
    for (int i = 1; i < n; i++)
    {
        temp = T[i];
        j = i - 1;
        while (j >= 0 && temp < T[j])
        {
            T[j + 1] = T[j];
            j--;
        }
        T[j + 1] = temp;
    }
    return T;
}
insert_sort(T);


// 4. Przez zliczanie (counting sort)

int[] count_sort(int[] T)
{
    int[] L = new int[100];
    for (int i = 0; i < n; i++)
        L[T[i]]++;

    for (int i = 0; i < L.Length; i++)
        Console.Write(L[i] + " ");
    Console.WriteLine();

    int j = 0;
    for (int i = 0; i < L.Length; i++)
    {
        if (L[i] > 0)
        {
            for (int k = 0; k < L[i]; k++)
            {
                T[j] = i;
                j++;
            }
        }
    }
    return T;
}
count_sort(T);


// 5. Kubełkowe

// pominięte - na później

// Dziel i zwyciężaj 


// 6. Przez scalanie (merge sort)

void merging(int left, int right)
{
    int[] pom = new int[n];
    for (int a = 0; a < n; a++)
        pom[a] = T[a];
    int i, i_left, i_right;
    int center = (left + right) / 2;
    i = left;   // indeks tabeli
    i_left = left;
    i_right = center + 1;

    while (i_left <= center && i_right <= right)
    {
        if (pom[i_left] < pom[i_right])
        {
            T[i] = pom[i_left];
            i_left++;
        }
        else
        {
            T[i] = pom[i_right];
            i_right++;
        }
        i++;
    }
    if (i_left > center)
        while (i_right <= right)
        {
            T[i] = pom[i_right];
            i_right++;
            i++;
        }
    else
        while (i_left <= center)
        {
            T[i] = pom[i_left];
            i_left++;
            i++;
        }
}

void sort(int left, int right)
{
    int center = (left + right) / 2;
    if (left < center)
    {
        sort(left, center);
    }
    if (center + 1 < right)
    {
        sort(center + 1, right);
    }
    merging(left, right);
}
sort(0, n - 1);


// 7. Quicksort Hoare

void sort_hoare(int left, int right)
{
    int i = left;
    int j = right;
    int temp;
    int pivot = T[(left + right) / 2];

    while (i <= j)
    {
        while (T[i] < pivot) i++;
        while (T[j] > pivot) j--;
        if (i <= j)
        {
            temp = T[i];
            T[i] = T[j];
            T[j] = temp;
            i++;
            j--;
        }
    }
    if (left < j) sort_hoare(left, j);
    if (right > i) sort_hoare(i, right);
}
sort_hoare(0, n - 1);


// 8. Quicksort Lomuto
void sort_lomuto(int left, int right)
{
    int pivot = T[right];
    int i = left;
    int temp;
    for (int k = left; k < right; k++)
    {
        if (T[k] <= pivot)
        {
            temp = T[i];
            T[i] = T[k];
            T[k] = temp;
            i++;
        }
    }
    temp = T[i];
    T[i] = T[right];
    T[right] = temp;

    if (left < i - 1) sort_lomuto(left, i - 1);
    if (right > i + 1) sort_lomuto(i + 1, right);
}
sort_lomuto(0, n - 1);

// 9. Sortowanie grzebieniowe
void sort_grzebien(int[] T)
{
    int temp;
    int gap = n;
    bool swapped = true;
    while (gap > 1 || swapped == true)
    {
        gap *= 10 / 13;
        if (gap == 0)
            gap = 1;
        swapped = false;
        for (int i = 0; i < n - gap; i++)
        {
            if (T[i] > T[i + gap])
            {
                temp = T[i];
                T[i] = T[i + gap];
                T[i + gap] = temp;
                swapped = true;
            }
        }
    }
    
}
sort_grzebien(T);


// Wyswietlenie posortowanej tablicy
for (int i = 0; i < n; i++)
    Console.Write(T[i] + " ");
