namespace Chapter4APIControllers.Models;

public class TaskEntity
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
}
