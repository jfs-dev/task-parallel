namespace task_parallel.Shared;

public static class TaskParallelTwo
{
    public static void TaskRun()
    {
        ConsoleLock.WriteLine("Tarefa 2 iniciada em paralelo, duração 5s.", ConsoleColor.Blue);
        
        Task.Delay(5000).Wait();
        
        ConsoleLock.WriteLine("Tarefa 2 finalizada em paralela com sucesso!", ConsoleColor.Blue);
    }    
}