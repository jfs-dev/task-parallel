namespace task_parallel.Shared;

public static class TaskParallelFour
{
    public static void TaskRun()
    {
        ConsoleLock.WriteLine("Tarefa 4 iniciada em paralelo, duração 8s.", ConsoleColor.Red);
        
        Task.Delay(8000).Wait();
        
        ConsoleLock.WriteLine("Tarefa 4 finalizada em paralela com sucesso!", ConsoleColor.Red);
    }    
}