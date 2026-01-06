using Microsoft.AspNetCore.Mvc.Formatters;
using System.Data;
using ToDo.Models;

namespace ToDo.DataAcces
{
    public class ViewModelFactory
    {

        ModelFactory modelFactory ;
        DbHelper dbHelper;
        public ViewModelFactory(DbHelper dbHelper)
        {
            this.modelFactory = new ModelFactory();
            this.dbHelper = dbHelper;   
        }


        public City[] GetAllCities()
        {
            string sql = "Select * from cities";
            DataTable dataTable = this.dbHelper.GetDataTable(sql, "Cities");
            City[] cities = new City[dataTable.Rows.Count];
            for (int i = 0; i < cities.Length; i++)
            {
                cities[i] = this.modelFactory.GetCity(dataTable.Rows[i]);
            }
            return cities;  
        }

        public TaskViewModel GetTaskVieModel(string userId)
        {
            string sqlTaskTypes = $"Select * from TaskTypes Where Useid='{userId}'";
            DataTable taskTypesDataTable = this.dbHelper.GetDataTable(sqlTaskTypes, "TaskTypes");
            string sqlTaskTodos = $"Select * from Tasks Where Useid='{userId}'";
            DataTable taskTodosDataTable = this.dbHelper.GetDataTable(sqlTaskTodos, "Tasks");
            TaskViewModel taskViewModel = new TaskViewModel(taskTypesDataTable.Rows.Count,
                                                            taskTodosDataTable.Rows.Count);
            for(int i = 0; i < taskTypesDataTable.Rows.Count; i++)
            {
                TaskType taskType = this.modelFactory.GetTaskType(taskTypesDataTable.Rows[i]);
                taskViewModel.AddTaskType(taskType);
            }
            for (int i = 0; i < taskTodosDataTable.Rows.Count; i++)
            {
                TaskTodo taskTodo = this.modelFactory.GetToDoItem(taskTodosDataTable.Rows[i]);
                taskViewModel.AddTaskTodo(taskTodo);
            }

            return taskViewModel;     
             
        }

        public TaskType[] GetAllTaskType(string userId)
        {
           
            string sqlTaskTypes = $"Select * from TaskTypes Where Useid='{userId}'";
            DataTable taskTypesDataTable = this.dbHelper.GetDataTable(sqlTaskTypes, "TaskTypes");
            TaskType[] taskTypes = new TaskType[taskTypesDataTable.Rows.Count];
            for (int i = 0; i < taskTypesDataTable.Rows.Count; i++)
            {
                TaskType taskType = this.modelFactory.GetTaskType(taskTypesDataTable.Rows[i]);
                taskTypes[i] =taskType;
            }
            return taskTypes;
        }

        public bool AddNewToDo(TaskTodo taskTodo)
        {
            string sql = @$"Insert into Tasks(TaskName,TaskDescription,TaskUrgent,TaskDate,UserId)
                           values('{taskTodo.GetTaskName()}','{taskTodo.GetTaskDescription}',
                                   {taskTodo.GetTaskUrgent()},'{taskTodo.GetTaskDate()}','{taskTodo.GetUserId()}'";
            return  this.dbHelper.ChangeDb(sql)>0;
        }

        public bool UpdateToDo(TaskTodo taskTodo)
        {
            string sql = @$"Update Tasks set TaskName='{taskTodo.GetTaskName()}',
                                             TaskDescription='{taskTodo.GetTaskDescription},
                                             TaskUrgent={taskTodo.GetTaskUrgent()},
                                             TaskDate='{taskTodo.GetTaskDate()}',
                                             UserId='{taskTodo.GetUserId()}')";
            return this.dbHelper.ChangeDb(sql) > 0;
        }

    }
}
