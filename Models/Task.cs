namespace ToDo.Models
{
    public class TaskTod
    {
        int taskId;
        string taskDescription;
        int taskUrgent;
        string taskDate;
        int taskStatus;
        string userId;
        int taskTypeId;

        public TaskTod(int taskId, string taskDescription, int taskUrgent, string taskDate, int taskStatus, string userId, int taskTypeId)
        {
            this.taskId = taskId;
            this.taskDescription = taskDescription;
            this.taskUrgent = taskUrgent;
            this.taskDate = taskDate;
            this.taskStatus = taskStatus;
            this.userId = userId;
            this.taskTypeId = taskTypeId;
        }
        public int GetTaskId()
        {
            return this.taskId;
        }
        public void SetTaskId(int taskId)
        {
            this.taskId = taskId;
        }

        public string GetTaskDescription()
        {
            return this.taskDescription;
        }
        public void SetTaskDescription(string taskDescription)
        {
            this.taskDescription = taskDescription;
        }

        public int GetTaskUrgent()
        {
            return this.taskUrgent;
        }
        public void SetTaskUrgent(int taskUrgent)
        {
            this.taskUrgent = taskUrgent;
        }

        public string GetTaskDate()
        {
            return this.taskDate;
        }
        public void SetTaskDate(string taskDate)
        {
            this.taskDate = taskDate;
        }

        public int GetTaskStatus()
        {
            return this.taskStatus;
        }
        public void SetTaskStatus(int taskStatus)
        {
            this.taskStatus = taskStatus;
        }

        public string GetUserId()
        {
            return this.userId;
        }
        public void SetUserId(string userId)
        {
            this.userId = userId;
        }

        public int GetTaskTypeId()
        {
            return this.taskTypeId;
        }
        public void SetTaskTypeId(int taskTypeId)
        {
            this.taskTypeId = taskTypeId;
        }


    }
}
