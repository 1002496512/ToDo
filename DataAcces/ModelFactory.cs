using System.Data;
using ToDo.Models;

namespace ToDo.DataAcces
{
    public class ModelFactory
    {
        public User GetUser(DataRow dataRow)
        {
            string userId= dataRow["userId"].ToString();
            string userAddress = dataRow["userAddress"].ToString();
            string userFirstName = dataRow["userFirstName"].ToString();
            string userLastname = dataRow["userLastname"].ToString();
            string userTelephone = dataRow["userTelephone"].ToString();
            int citeId =int.Parse( dataRow["citeId"].ToString());
            string userEmail = dataRow["userEmail"].ToString();
            string userNickName = dataRow["userNickName"].ToString();
            string userPassword = dataRow["userPassword"].ToString();
            string userPicture = dataRow["userPicture"].ToString();
            return new User(userId,
                            userAddress,
                            userFirstName,
                            userLastname,
                            userTelephone,
                            citeId,
                            userEmail,
                            userNickName,
                            userPassword,
                            userPicture);
        }

        public City GetCity(DataRow dataRow)
        {
            int citeId = int.Parse(dataRow["citeId"].ToString());
            string citeName = dataRow["citeName"].ToString();
            return new City(citeId, citeName);
        }

        public TaskTod GetToDoItem(DataRow dataRow)
        {
            int taskId = int.Parse( dataRow["taskId"].ToString());
            string taskDescription= dataRow["taskDescription"].ToString();
            int taskUrgent= int.Parse(dataRow["taskUrgent"].ToString()); ;
            string taskDate=dataRow["taskDate"].ToString();
            int taskStatus= int.Parse(dataRow["taskStatus"].ToString());
            string userId=dataRow["userId"].ToString();
            int taskTypeId=int.Parse(dataRow["taskTypeId"].ToString());
            return new TaskTod(taskId,
                              taskDescription,
                              taskUrgent,
                              taskDate,
                              taskStatus,
                              userId,
                              taskTypeId);
        }
    }
}
