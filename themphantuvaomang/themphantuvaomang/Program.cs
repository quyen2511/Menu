namespace themphantuvaomang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("nhap so can chen:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vi tri:");
            int z = int.Parse(Console.ReadLine());
            int y=0;
            y = z - 1;
            int[] num2 = new int[num.Length + 1];
            for(int i=0 ;i<=y;i++) 
            { 
                num2[i] = num[i]; 
            }
            if (y > 1 && y < num.Length - 1)
            {
                for (int i = y; i < num2.Length-1; i++)
                {
                    num2[i + 1] = num[i];
                }
                num2[y] = x;
            }
            for (int i = 0; i < num2.Length; i++)
            {
                Console.WriteLine(num2[i]);               
            }
        }
    }
}
