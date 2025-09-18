class Program
{
    static void PrintNumber(String message)
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"{message}:{i}");
            Thread.Sleep(1000);
        }
    }
    private static void Main(string[] args)
    {
        Thread.CurrentThread.Name = "Main";
        Task task1 = new Task(() => PrintNumber("Task 01"));  
        task1.Start();
        Task task2 = Task.Run(delegate { PrintNumber("Task 02"); });
        Task task3 = new Task(new Action(() => PrintNumber("Task 03")));
        task3.Start();
        Console.WriteLine($"Thread '{Thread.CurrentThread.Name}'");
        Console.ReadKey();
    }
}