﻿using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] array = {{1,2,3,4},
                        {1,2,16,4},
                        {5,6,7,8},
                        {9,10,11,12}};
        int max = array[0, 0];
        int n = 0;
        int m = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                    n = i;
                    m = j;
                }
            }
        }
        Console.WriteLine("Gia tri lon nhat cua mang la" + max + "\t" + n + m);
    }
}