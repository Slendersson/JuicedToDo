using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juiced_ToDo
{
    public class loginContext
    {
        private bool isLoggedIn { get; set; }
        private int userID;
        private string emailAddress;

        public loginContext()
        {
            isLoggedIn = false;
            userID = -1;
            emailAddress = String.Empty;
        }
        
        public void setIsLoggedIn(bool isLoggedIn)
        {
            this.isLoggedIn = isLoggedIn;
        }
        public void setUserID(int userID)
        {
            this.userID = userID;
        }
        public void setEmailAddress(string emailAddress)
        {
            this.emailAddress = emailAddress;
        }
        public bool getIsLoggedIn()
        {
            return isLoggedIn;
        }
        public int getUserID()
        {
            return userID;
        }
        public string getEmailAddress()
        {
            return emailAddress;
        }
    }
}
