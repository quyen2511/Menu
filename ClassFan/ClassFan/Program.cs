namespace ClassFan
{
    public class Fan
    {
        public const int SLOW= 1, MEDIUM= 2, FAST= 3;

        private int speed = 1;

        private bool on=false;

        private double radius = 5;

        private string color = "blue";
        public int Speed { get => speed; set => speed = value; }
        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }
        public override string ToString()
        {
            if (on)
            {
                return $"Speed: {speed}, Color: {color}, Radius: {radius} - Fan is on";
            }
            else
            {
                return $"Color: {color}, Radius: {radius} - Fan is off";
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            Fan fan2 = new Fan();

            Console.WriteLine(fan1.ToString());
            Console.WriteLine(fan2.ToString());

            fan1.On = true;
            fan1.Speed = Fan.FAST;
            fan1.Radius = 10;
            fan1.Color = "yellow";

            fan2.Speed = Fan.MEDIUM;

            Console.WriteLine(fan1.ToString());
            Console.WriteLine(fan2.ToString());
        }
    }
}
