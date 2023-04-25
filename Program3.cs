using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int[] arr = new int[200];  
        Random rnd = new Random();  
        int n = 19;  

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 101);
        }

        Console.WriteLine("Вхідний масив:");
        Console.WriteLine(string.Join(" ", arr));  

       
        Array.Sort(arr);
        Array.Reverse(arr);

        Console.WriteLine("Відсортований масив:");
        Console.WriteLine(string.Join(" ", arr));  

        int nthLargest = arr[n - 1];  
        Console.WriteLine($"Значення {n}-го елемента за величиною: {nthLargest}");

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > nthLargest)
            {
                arr[i] = nthLargest;
            }
        }

        Console.WriteLine("Вихідний масив:");
        Console.WriteLine(string.Join(" ", arr));  
    }
}
