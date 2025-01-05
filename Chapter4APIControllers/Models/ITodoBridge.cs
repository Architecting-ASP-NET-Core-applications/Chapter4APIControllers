namespace Chapter4APIControllers.Models;

public interface ITodoBridge
{
    List<TaskEntity> GetAllTasks();
    TaskEntity GetById(int id);
    void CreateTodo(TaskEntity entity);
}
