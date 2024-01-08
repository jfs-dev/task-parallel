namespace task_parallel.Shared;

public static class TaskParallelThree
{
    public static void TaskRun()
    {
        ConsoleLock.WriteLine("Tarefa 3 iniciada em paralelo, duração 3s.", ConsoleColor.Magenta);
        
        Task.Delay(3000).Wait();
        
        ConsoleLock.WriteLine("Tarefa 3 finalizada em paralela com sucesso!", ConsoleColor.Magenta);
    }    
}