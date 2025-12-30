namespace ToDo.Models
{
    public class TaskType
    {
        int taskTypeId;
        string taskTypeName;
        string userId;

        public TaskType(int taskTypeId, string taskTypeName, string userId)
        {
            this.taskTypeId = taskTypeId;
            this.taskTypeName = taskTypeName;
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

        public string GetTaskTypeName()
        {
            return this.taskTypeName;
        }

        public void SetTaskTypeName(string taskTypeName)
        {
            this.taskTypeName = taskTypeName;
        }

        public string GetUserId()
        {
            return this.userId;
        }

        public void SetUserId(string userId)
        {
            this.userId = userId;
        }
    }
}
