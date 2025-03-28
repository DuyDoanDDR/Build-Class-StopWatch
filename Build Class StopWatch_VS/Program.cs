using System.Diagnostics;

public class StopWatch
{
    private DateTime startTime;
    private DateTime endTime;
    public DateTime StartTime
    {
        get { return startTime; }
        set { startTime = value; }
    }
    public DateTime EndTime
    {
        get { return endTime; }
        set { endTime = value; }
    }
    public StopWatch()
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
    public double GetElapseTime()
    {
        return (endTime - startTime).TotalMilliseconds;
    }
}
public class Program
{
    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            int MinIndex = i;
            for (int j = i+1; j < n ; j++)
            {
                if (arr[j] < arr[MinIndex])
                {
                   MinIndex = j;
                }
            }
            int temp = arr[MinIndex];
            arr[MinIndex] = arr[i];
            arr[i] = temp;
        }
    }

    public static void Main(string[] args)
    {
        Random random = new Random();
        int[] numbers = new int[100000];
        
        for (int i = 0;i < numbers.Length;i++)
        {
            numbers[i] = random.Next(1,1000000); 
        }

        StopWatch SW01 = new StopWatch();

        SW01.Start();
        SelectionSort(numbers);
        SW01.Stop();

        Console.WriteLine($"Thoi gian thuc thi Selection Sort: {SW01.GetElapseTime()} milliseconds");
    }

}