using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    class Public
    {
        private int a;

        //用户名
        private string _ChooseVote = "";
        public string ChooseVote { get { return _ChooseVote; } set { _ChooseVote = value; } }

        private static Public _VoteName = null;

        //应用单件模式，保存用户登录状态
        public static Public VoteName
        {
            get
            {
                if (_VoteName == null)
                    _VoteName = new Public();
                return _VoteName;
            }
        }
    }
}
