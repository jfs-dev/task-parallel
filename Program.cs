using task_parallel.Shared;

Parallel.Invoke(
    TaskParallelOne.TaskRun,
    TaskParallelTwo.TaskRun,
    TaskParallelThree.TaskRun,
    TaskParallelFour.TaskRun
);