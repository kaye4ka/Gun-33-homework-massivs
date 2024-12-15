using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int[] sequence = new int[8];
        sequence[0] = 0;
        sequence[1] = 1;

        for (int i = 2; i < 8; i++)
        {
            sequence[i] = sequence[i - 1] + sequence[i - 2];
        }

        Console.WriteLine("Первые восемь  чисел последовательности");
        foreach (int num in sequence)
        {
            Console.WriteLine(num + " ");
        }
    }
}

class Program
{
    static void Main()
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        foreach (string month in months)
        {
            Console.WriteLine(month);
        }
    }
}

class Program
{
    static void Main()
    {
        int[,] matrix = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            matrix[0, i] = (int)Math.Pow(2, i + 1);
            matrix[1, i] = (int)Math.Pow(2, i + 1);
            matrix[2, i] = (int)Math.Pow(2, i + 1);
        }

        Console.WriteLine("Матрица:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(matrix[i, j] + " ");
            }
            Console.WriteLine()
        }
    }
}

class Program
{
    static void Main()
    {
        double[][] jaggedArray = new double[][]
        {
            new double[] { 1, 2, 3, 4, 5, },
            new double[] { Math.E, Math.PI },
            new double[] { Math.Log10(100), Math.Log10(1000) }
        };
        foreach (double[] subArray in jaggedArray)
        {
            foreach (double[] num in jaggedArray)
            {
                Console.Write(num + " ");
            }
            Console.Write();
        }
    }
}

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
        double[][] jaggedArray = new double[2][];
        jaggedArray[0] = new double[array.Length];
        jaggedArray[1] = new double[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            jaggedArray[0][i] = Math.Pow(array[i], 2);
        }

        for (int j = 0; j < array2.Length; j++)
        {
            jaggedArray[1][j] = Math.Log(array2[j]);
        }

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.WriteLine($"{jaggedArray[i][j]}");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

        Array.Copy(array, array2, 3);

        Console.WriteLine("Modified array2[]:");
        foreach (int i in array2)
        {
            Console.WriteLine(i + " ");
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        ResizeArray(ref numbers, numbers.Length * 2);

        Console.WriteLine("Увеличиваем массив");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
    static void ResizeArray(ref int[] Array, int newSize)
    {
        Array.Resize(ref Array, newSize);
    }
}

