namespace Sumfiletext
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            string sourcepath = @"C:\DATA\map.txt";
            FileInfo finfo = new FileInfo(sourcepath);
            if (finfo.Exists)
            {
                StreamReader reader = new StreamReader(sourcepath);
                string line="";               
                while ((line=reader.ReadLine())!=null)
                {
                    Console.WriteLine(line);
                    sum+= Int32.Parse(line);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
