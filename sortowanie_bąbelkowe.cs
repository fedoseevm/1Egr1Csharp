// SORTOWANIE BĄBELKOWE
Random r = new Random();
int[] SB = new int[20];
for (int i = 0; i < SB.Length; i++)
    SB[i] = r.Next(0, 100);

int temp;
for (int i = 0; i < SB.Length; i++)
{
    for (int j = i; i < SB.Length - 1; i++)
    {
        if (SB[j] > SB[j + 1])
        {
            temp = SB[j];
            SB[j] = SB[j + 1];
            SB[j + 1] = temp;
        }
    }
    //Console.WriteLine(SB[i]);
}
foreach (int item in SB)
{
    Console.Write(item + " ");
}
