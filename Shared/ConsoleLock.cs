namespace task_parallel.Shared;

public static class ConsoleLock
{
    static readonly object consoleLock = new();

    public static void WriteLine(string mesage, ConsoleColor color)
    {
        lock (consoleLock)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mesage);
        }
    }
}