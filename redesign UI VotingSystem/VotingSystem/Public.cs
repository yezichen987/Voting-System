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

        //vote name
        private string _ChooseVote = "";
        public string ChooseVote { get { return _ChooseVote; } set { _ChooseVote = value; } }

        private static Public _VoteName = null;

        //save vote name 
        public static Public VoteName
        {
            get
            {
                if (_VoteName == null)
                    _VoteName = new Public();
                return _VoteName;
            }
        }
        // this is choosed candidate name
        private string _ChooseCandidate = "";
        public string ChooseCandidate { get { return _ChooseCandidate; } set { _ChooseCandidate = value; } }

        private static Public _CandidateName = null;

        //store candidate name
        public static Public CandidateName
        {
            get
            {
                if (_CandidateName == null)
                    _CandidateName = new Public();
                return _CandidateName;
            }
        }
    }
}
