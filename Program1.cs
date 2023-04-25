using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        double[] arr = { -2, 8, 5, 0, -10, 3, -1, 4 };
        int count = 0;
        double product = 1;
        double max = arr[0];
        int maxIndex = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 3)
            {
                count++;
            }
            if (Math.Abs(arr[i]) > Math.Abs(max))
            {
                max = arr[i];
                maxIndex = i;
            }
        }
        for (int i = maxIndex + 1; i < arr.Length; i++)
        {
            product *= arr[i];
        }

        Array.Sort(arr, (x, y) => x.CompareTo(y));

        Console.WriteLine("Кількість елементів більших за 3: " + count);
        Console.WriteLine("Добуток елементів після максимального елемента: " + product);
        Console.WriteLine("Перетворений масив: ");
        foreach (double elem in arr)
        {
            Console.Write(elem + " ");
        }
    }
}
