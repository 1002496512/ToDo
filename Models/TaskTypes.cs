namespace ToDo.Models
{
    public class TaskTypes
    {
        int taskTypeId;
        string taskTypeName;

        public TaskTypes(int taskTypeId, string taskTypeName)
        {
            this.taskTypeId = taskTypeId;
            this.taskTypeName = taskTypeName;
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
    }
}
