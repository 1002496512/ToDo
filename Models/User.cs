namespace ToDo.Models
{
    public class User
    {
        string userId;
        string userAddress;
        string userFirstName;
        string userLastname;
        string userTelephone;
        int  citeId;
        string userEmail;
        string userNickName;
        string userPassword;
        string userPicture;

        public User(string userId,
                    string userAddress,
                    string userFirstName,
                    string userLastname,
                    string userTelephone,
                    int citeId,
                    string userEmail,
                    string userNickName,
                    string userPassword,
                    string userPicture) 
        
        {
            this.userId = userId;
            this.userAddress = userAddress;
            this.userFirstName = userFirstName;
            this.userLastname = userLastname;
            this.userTelephone = userTelephone;
            this.citeId = citeId;
            this.userEmail = userEmail;
            this.userNickName = userNickName;
            this.userPassword = userPassword;
            this.userPicture = userPicture;
                
        }
        public string GetUserId()
        {
            return this.userId;
        }
        public void SetUserId(string userId)
        {
            this.userId = userId;
        }

        public string GetUserAddress()
        {
            return this.userAddress;
        }
        public void SetUserAddress(string userAddress)
        {
            this.userAddress = userAddress;
        }

        public string GetUserFirstName()
        {
            return this.userFirstName;
        }
        public void SetUserFirstName(string userFirstName)
        {
            this.userFirstName = userFirstName;
        }

        public string GetUserLastname()
        {
            return this.userLastname;
        }
        public void SetUserLastname(string userLastname)
        {
            this.userLastname = userLastname;
        }

        public string GetUserTelephone()
        {
            return this.userTelephone;
        }
        public void SetUserTelephone(string userTelephone)
        {
            this.userTelephone = userTelephone;
        }

        public int GetCiteId()
        {
            return this.citeId;
        }
        public void SetCiteId(int citeId)
        {
            this.citeId = citeId;
        }

        public string GetUserEmail()
        {
            return this.userEmail;
        }
        public void SetUserEmail(string userEmail)
        {
            this.userEmail = userEmail;
        }

        public string GetUserNickName()
        {
            return this.userNickName;
        }
        public void SetUserNickName(string userNickName)
        {
            this.userNickName = userNickName;
        }

        public string GetUserPassword()
        {
            return this.userPassword;
        }
        public void SetUserPassword(string userPassword)
        {
            this.userPassword = userPassword;
        }

        public string GetUserPicture()
        {
            return this.userPicture;
        }
        public void SetUserPicture(string userPicture)
        {
            this.userPicture = userPicture;
        }


    }
}
