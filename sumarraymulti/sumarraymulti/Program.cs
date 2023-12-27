internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so hang");
        int row = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so cot");
        int colum = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap cac phan tu cua mang");
        int[,] array = new int[row, colum];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < colum; j++)
            {
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
        //in cac phan tu cua mang
        for (int i = 0; i < row; i++)
        {
            Console.WriteLine("\n");
            for (int j = 0; j < colum; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
        }
        //tinh tong
        int total = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < colum; j++)
            {
                if (i == j)
                {
                    total += array[i, j];
                }
            }
        }
        Console.WriteLine("Gia tri tong duong cheo la " + total);
    }
}
