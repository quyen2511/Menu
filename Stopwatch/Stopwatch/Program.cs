using System;

public class Stopwatch
{
    private DateTime startTime;
    private DateTime endTime;

    public DateTime StartTime
    {
        get { return startTime; }
    }

    public DateTime EndTime
    {
        get { return endTime; }
    }

    public Stopwatch()
    {
        startTime = DateTime.Now;
    }

    public void Start()
    {
        startTime = DateTime.Now;
    }

    public void Stop()
    {
        endTime = DateTime.Now;
    }

    public long GetElapsedTime()
    {
        TimeSpan elapsedTime = endTime - startTime;
        return (long)elapsedTime.TotalMilliseconds;
    }
}

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();

        int[] numbers = GenerateRandomArray(100000);
        SelectionSort(numbers);

        stopwatch.Stop();

        Console.WriteLine($"Elapsed Time: {stopwatch.GetElapsedTime()} milliseconds");
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next();
        }
        return array;
    }

    static void SelectionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }
}
