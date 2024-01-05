using System;

namespace Xoaphantukhoimang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So phan tu cua mang");
            int n= int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("phan tu can xoa");
            int x= int.Parse(Console.ReadLine());
            Console.WriteLine("nhap gia tri vao mang");
            for(int i = 0; i < n; i++)
            {
                int num= int.Parse(Console.ReadLine());
                array[i] = num;
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] == x )
                {
                    int index_del = i;
                    int[] num2 = new int[array.Length - 1];
                    for(int j = 0; j < index_del; j++)
                    {
                        num2[j] = array[j];
                    }
                    for (int j = index_del;j < num2.Length; j++)
                    {
                        num2[j] = array[j + 1];
                    }
                    Console.WriteLine("in ra mang");
                    for (int j = 0; j < num2.Length; j++)
                    {
                        Console.WriteLine(num2[j]);
                    }
                }
            }
        }
    }
}
