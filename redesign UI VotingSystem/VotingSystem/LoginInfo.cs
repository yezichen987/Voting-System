using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    public class LoginInfo
    {

 
        //user name
        private string _UserName = "";
        public string UserName { get { return _UserName; } set { _UserName = value; } }
 
        private static LoginInfo _CurrentUser = null;
 
        //save the login statement
        public static LoginInfo CurrentUser
        {
            get
            {
                if (_CurrentUser == null)
                    _CurrentUser = new LoginInfo();
                return _CurrentUser;
            }
        }
    }
}
