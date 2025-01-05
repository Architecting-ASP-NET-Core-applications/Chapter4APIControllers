namespace Chapter4APIControllers.Models;

public class TodoBridge : ITodoBridge
{
    private List<TaskEntity> tasks = new List<TaskEntity>();
    public TodoBridge()
    {
        tasks.Add(new TaskEntity { Id = 1, Description = "Task 1", IsCompleted = false });
        tasks.Add(new TaskEntity { Id = 2, Description = "Task 2", IsCompleted = false });
        tasks.Add(new TaskEntity { Id = 3, Description = "Task 3", IsCompleted = false });
    }
    public List<TaskEntity> GetAllTasks()=>tasks;
    public TaskEntity GetById(int id) =>
        tasks.FirstOrDefault(t => t.Id == id) 
            ?? throw new KeyNotFoundException($"Task with Id {id} not found.");
    public void CreateTodo(TaskEntity entity) => tasks.Add(entity);
}
