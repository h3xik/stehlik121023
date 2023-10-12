// See https://aka.ms/new-console-template for more information
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("nigga");

int[] pole = new int[] {1, 2, 3, 5, 2, 4, 8, 1, 2, 4877};

static int pocetPrvku(int[] arr)
{
    int n = 0;
    foreach (int x in arr)
    {
        n++;
    }
    return n;
}

static int maximumVPoli(int[] arr)
{
    int n = 0;
    foreach (int x in arr)
    {
        if (x > n)
        {
            n = x;
        }
    }
    return n;
}

static int minimumVPoli(int[] arr)
{
    int n = 0;
    foreach (int x in arr)
    {
        if (x < n)
        {
            n = x;
        }
    }
    return n;
}

static int soucetPole(int[] arr)
{
    int n = 0;
    foreach (int x in arr)
    {
        n += x;
    }
    return n;
}

static int soucinPole(int[] arr)
{
    int n = 1;
    foreach (int x in arr)
    {
        n *= x;
    }
    return n;
}

static double prumerPole(int[] arr)
{
    double n = 0;
    foreach (int x in arr)
    {
        n += x;
    }
    n /= arr.Length;
    return n;
}

static double geomPrumerPole(int[] arr)
{
    double n = 1;
    int pocet = 0;
    foreach (int x in arr)
    {
        if (x <= 0)
        {
            continue;
        }
        n *= x;
        pocet++;
    }
    double t = Math.Pow(n, 1.0 / pocet);

    return t;
}

static int median(int[] arr)
{
    int[] arrSorted = (int[])arr.Clone();
    Array.Sort(arrSorted);

    // Přesně počítá medián jen u polí se sudým počtem prvků
    return arrSorted[arrSorted.Length / 2];
}


Console.WriteLine("Počet prvků v poli: " + pocetPrvku(pole));
Console.WriteLine("Maximum v poli: " + maximumVPoli(pole));
Console.WriteLine("Minimum v poli: " + minimumVPoli(pole));
Console.WriteLine("Součet: " + soucetPole(pole));
Console.WriteLine("Součin: " + soucinPole(pole));
Console.WriteLine("Aritmetický průměr: " + prumerPole(pole));
Console.WriteLine("Geometrický průměr: " + geomPrumerPole(pole));
Console.WriteLine("Median: " + median(pole));