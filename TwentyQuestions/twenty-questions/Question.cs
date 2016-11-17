using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twenty_questions
{
    class Question
    {
        public string question;
        public Question yes;
        public Question no;
        public Question parent;

        public bool isLeaf()
        {
            return yes == null && no == null;
        }
    }
}
