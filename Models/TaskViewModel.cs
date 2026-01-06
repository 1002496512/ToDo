namespace ToDo.Models
{
    public class TaskViewModel
    {
        TaskType[] taskTypes;
        TaskTodo[] taskTodos;
        int taskTypesCount;
        int taskTodosCount;

        public TaskViewModel(int taskCount, int taskTodoCount)
        {
            this.taskTypes = new TaskType[taskCount];
            this.taskTodos = new TaskTodo[taskTodoCount];
            this.taskTypesCount = 0;
            this.taskTodosCount = 0;

        }

        public void AddTaskType(TaskType taskType)
        {
            this.taskTypes[this.taskTypesCount] = taskType;
            this.taskTypesCount++;
        }

        public void AddTaskTodo(TaskTodo taskTodo)
        {
            this.taskTodos[this.taskTodosCount] = taskTodo;
            this.taskTodosCount++;
        }   

        public TaskType GetTaskType(int index)
        {
            return this.taskTypes[index];
        }

        public TaskTodo GetTaskTodo(int index)
        {
            return this.taskTodos[index];
        }

        public int GetTaskTypesCount()
        {
            return this.taskTypesCount;
        }

        public int GetTaskTodosCount()
        {
            return this.taskTodosCount;
        }
    }
}
