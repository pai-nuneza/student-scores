

int[] allSectionsAverage = new int[3];

MyMethods methods = new MyMethods();
int[][] sections = new int[3][];

sections[0] = new int[] { 78, 70, 60, 83, 92, 78, 40 };
sections[1] = new int[] { 65, 67, 23, 34, 46, 65 };
sections[2] = new int[] { 91, 94, 93, 96 };

Console.WriteLine(sections.Min());

for (int s = 0; s < sections.Length; s++)
{
    Console.WriteLine("Section: " + s);

    Console.WriteLine("Average: " + methods.GetAverage(sections[s]));
    Console.WriteLine("Max: " + methods.GetMaximumValue(sections[s]));
    Console.WriteLine("Min: " + methods.GetMinimumValue(sections[s]));
    Console.WriteLine();
    allSectionsAverage[s] = (int)methods.GetAverage(sections[s]);
}



class MyMethods
{
    public float GetAverage(int[] arr) {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];
        
        return (float)sum / arr.Length;
    }

    public int GetMaximumValue(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; ++i)
            if (arr[i] > max)
                max = arr[i];

        return max;
    }

    public int GetMinimumValue(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; ++i)
            if (arr[i] < min)
                min = arr[i];

        return min;
    }
}


