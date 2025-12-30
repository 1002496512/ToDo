namespace ToDo.Models
{
    public class TodoListViewModel
    {
       TaskTod[] taskTods;
       int todoCount;
       TaskType[] taskTypes;
       int tasktypesCount;

        public TodoListViewModel(int taskTodsCount,int taskTypesCoumt)
        {
            this.todoCount = 0;
            this.tasktypesCount = 0;
            this.taskTods = new TaskTod[taskTodsCount];
            this.taskTypes = new TaskType[taskTypesCoumt];
        }

        public void AddTaskTod(TaskTod taskTod)
        {
            this.taskTods[this.todoCount] = taskTod;
            this.todoCount++;
        }

        public void AddTaskType(TaskType taskType)
        {
            this.taskTypes[this.todoCount]= taskType;
            this.tasktypesCount++;
        }

        public TaskTod[] GetTaskTods()
        {
            return this.taskTods;
        }

        public TaskType[] GetTaskTypes()
        {
            return this.taskTypes;
        }



    }
}
