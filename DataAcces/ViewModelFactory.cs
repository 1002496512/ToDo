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

        public TodoListViewModel GetTodoListViewModel( string userId, int taskTypeId = 0)
        {
           
            string sql = $"Select * from TaskTypes Where UserId='{userId}'";
            DataTable dtTaskTypes = this.dbHelper.GetDataTable(sql, "TaskTypes");
            sql = $"Select * from Tasks Where UserId='{userId}'";
            DataTable dtTasks = this.dbHelper.GetDataTable(sql, "TaskTypes");
            TodoListViewModel todoListViewModel = new TodoListViewModel(dtTasks.Rows.Count, dtTaskTypes.Rows.Count);    
            for (int i = 0;i < dtTasks.Rows.Count;i++) 
             {
                    TaskTod taskTod = this.modelFactory.GetToDoItem(dtTasks.Rows[i]);
                    todoListViewModel.AddTaskTod(taskTod);  
             }
             for(int i=0; i< dtTaskTypes.Rows.Count; i++)
             {
                 TaskType taskType = this.modelFactory.GetTaskType(dtTaskTypes.Rows[i]);
                todoListViewModel.AddTaskType(taskType);
             }
             return todoListViewModel;  
        }
    }
}
