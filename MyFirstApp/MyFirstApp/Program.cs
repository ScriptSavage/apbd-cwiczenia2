

int []arr = {1,2,3, 4, 5, 4, 3, 54, 65, 6, 7, 5, 5, -1, 0 };

static int maxValue(int[]tab)
{

    int max = tab[0];
    
    for (int i = 0; i < tab.Length; i++)
    {
        if (tab[i] > max)
        {
            max = tab[i];
        }
    }

    return max;
}



Console.WriteLine(maxValue(arr));