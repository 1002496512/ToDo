using Microsoft.AspNetCore.Mvc.Formatters;
using System.Data;
using ToDo.Models;

namespace ToDo.DataAcces
{
    public class ViewModelFactory
    {

        ModelFactory modelFactory;
        DbHelper dbHelper;
        public ViewModelFactory(DbHelper dbHelper)
        {
            this.modelFactory = new ModelFactory();
            this.dbHelper = dbHelper;
        }

        // Use case: Add New User 
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


        // Use case: View To Do List 
        public TaskViewModel GetTaskVieModel(string userId)
        {
            string sqlTaskTypes = $"Select * from TaskTypes Where Userid='{userId}'";
            DataTable taskTypesDataTable = this.dbHelper.GetDataTable(sqlTaskTypes, "TaskTypes");
            string sqlTaskTodos = $"Select * from Tasks Where Userid='{userId}'";
            DataTable taskTodosDataTable = this.dbHelper.GetDataTable(sqlTaskTodos, "Tasks");
            TaskViewModel taskViewModel = new TaskViewModel(taskTypesDataTable.Rows.Count,
                                                            taskTodosDataTable.Rows.Count);
            for (int i = 0; i < taskTypesDataTable.Rows.Count; i++)
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

        // Use case View To Do List 
        public TaskType[] GetAllTaskType(string userId)
        {

            string sqlTaskTypes = $"Select * from TaskTypes Where Useid='{userId}'";
            DataTable taskTypesDataTable = this.dbHelper.GetDataTable(sqlTaskTypes, "TaskTypes");
            TaskType[] taskTypes = new TaskType[taskTypesDataTable.Rows.Count];
            for (int i = 0; i < taskTypesDataTable.Rows.Count; i++)
            {
                TaskType taskType = this.modelFactory.GetTaskType(taskTypesDataTable.Rows[i]);
                taskTypes[i] = taskType;
            }
            return taskTypes;
        }

        //Use case:  Add New To Do and Update To do and Add document
        public bool AddNewToDo(TaskTodo taskTodo)
        {
            string sql = @$"Insert into Tasks(TaskName,TaskDescription,TaskUrgent,TaskDate,UserId)
                           values('{taskTodo.GetTaskName()}','{taskTodo.GetTaskDescription}',
                                   {taskTodo.GetTaskUrgent()},'{taskTodo.GetTaskDate()}','{taskTodo.GetUserId()}'";
            return this.dbHelper.ChangeDb(sql) > 0;
        }

        //Use case: Update To do
        public bool UpdateToDo(TaskTodo taskTodo)
        {
            string sql = @$"Update Tasks set TaskName='{taskTodo.GetTaskName()}',
                                             TaskDescription='{taskTodo.GetTaskDescription},
                                             TaskUrgent={taskTodo.GetTaskUrgent()},
                                             TaskDate='{taskTodo.GetTaskDate()}',
                                             UserId='{taskTodo.GetUserId()}'), 
                                             TaskStatus
                                             where TaskId={taskTodo.GetTaskId()}";
            return this.dbHelper.ChangeDb(sql) > 0;
        }

        //Use case: Update To do Status
        public bool UpdateStausToDo(int taskTodoId, int status)
        {
            string sql = @"Update Tasks set TaskStatus={status} where TaskId={taskTodoId}";
            return this.dbHelper.ChangeDb(sql) > 0;
        }

        // Use Case: Login User 
        public string LoginUser(string username, string password)
        {
            string sql = $@"Select UserId from Users
                             where UserNickName='{username}' 
                            and UserPassword='{password}'";
            DataTable dataTable = this.dbHelper.GetDataTable(sql, "Users");
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            return dataTable.Rows[0]["UserId"].ToString();

        }

        // Use Case:  User Registration
        public string AddNewUser(User user)
        {
            string sql = $@"Insert into Users(UserId,UserAddress, UserFirstName,
                            UserLastname,UserTelephone,CiteId,UserEmai,
                            UserNickName, UserPassword, UserPicture)
                            values('{user.GetUserId()}',
                                   '{user.GetUserAddress()}',
                                   '{user.GetUserFirstName()}',
                                   '{user.GetUserLastname()}',
                                   '{user.GetUserTelephone()}',
                                    {user.GetCiteId()},
                                    '{user.GetUserEmail()}',
                                    '{user.GetUserNickName()}',
                                    '{user.GetUserPassword()}',
                                    '{user.GetUserPicture()}'
                                  )";

            if (this.dbHelper.ChangeDb(sql) > 0)
            {
                return user.GetUserId();
            }
            return null;

        }
    }
}
