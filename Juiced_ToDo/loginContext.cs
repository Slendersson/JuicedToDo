using Juiced_ToDo.Models;
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
        private UserModel user { get; set; }

        public loginContext()
        {
            isLoggedIn = false;
            user = null;
        }
        
        public void setIsLoggedIn(bool isLoggedIn)
        {
            this.isLoggedIn = isLoggedIn;
        }

        public void setUser(UserModel user)
        {
            this.user = user;
        }

        public bool getIsLoggedIn()
        {
            return isLoggedIn;
        }
       public UserModel getUser()
        {
            return user;
        }

    }
}
