using System.Runtime.CompilerServices;

namespace Chuyendoitiente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float rate=23000;
            float USD;
            Console.Write("Enter USD: ");
            USD = float.Parse(Console.ReadLine());           
            float VND = USD * rate;
            Console.WriteLine("VND: " + VND);
        }
    }
}
