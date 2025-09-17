using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juiced_ToDo.Models
{
    public class UserModel
    {
        public UserModel(uint userID, string emailAddress)
        {
            this.userID = userID;
            this.emailAddress = emailAddress;   
        }
        public uint userID { get; set; }
        public string emailAddress { get; set; }

    }
}
