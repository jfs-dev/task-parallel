namespace task_parallel.Shared;

public static class TaskParallelOne
{
    public static void TaskRun()
    {
        ConsoleLock.WriteLine("Tarefa 1 iniciada em paralelo, duração 10s.", ConsoleColor.Green);
        
        Task.Delay(10000).Wait();
        
        ConsoleLock.WriteLine("Tarefa 1 finalizada em paralela com sucesso!", ConsoleColor.Green);
    }    
}