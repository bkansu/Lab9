using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab09
{
   

    [Serializable]
    class BSc:Student
    {
        public BSc(string name, string surname, int no)
        {
            base.name = name;
            base.surname = surname;
            base.no = no;
        }
    }
}
