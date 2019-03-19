using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    public class LoginInfo
    {

 
        //用户名
        private string _UserName = "";
        public string UserName { get { return _UserName; } set { _UserName = value; } }
 
        private static LoginInfo _CurrentUser = null;
 
        //应用单件模式，保存用户登录状态
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
