Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");


Console.WriteLine("Zmiana 1");



static double GetAvarage(int[]tab)
{
    double sredia = 0;

    double suma = 0;
    
    for (int i = 0; i < tab.Length; i++)
    {
        suma += tab[i];
    }

    sredia = suma / tab.Length;

    return sredia;
}

int[] arr = new int[] { 1,2,3,4};


Console.WriteLine(GetAvarage(arr));