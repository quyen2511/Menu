using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
       int choice=-1;
       while (choice!=0)
       {
        Console.WriteLine("Nhap lua chon");
        choice =  int.Parse(Console.ReadLine()); 
        switch (choice)
        {   

            case 1: 
            {
                //chuyen su C sang F
               Console.WriteLine(CelsiusToFahrenheit());
            }
            break;
            case 2: 
            {
               //chuyen tu F sang C
              Console.WriteLine(FahrenheitToCelsius());
            }
            break;
            case 0: 
            {
                Environment.Exit(0);
            }
            break;
            default:
            {
             Console.WriteLine("Nhap lai");
            }
            break;
        }     
       }
    }
    static double CelsiusToFahrenheit()
    {
                Console.WriteLine("Nhap do C");
                int celsius = int.Parse(Console.ReadLine());
                double fahrenheit = 9/5* celsius+32;
                return fahrenheit;
    }
    static double FahrenheitToCelsius()  
    {
               Console.WriteLine("Nhap do F");
               int fahrenheit = int.Parse(Console.ReadLine());
               double celsius = (fahrenheit-32)*5/9 ;
               return celsius;
    }

}