using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab09
{

    [Serializable]
    abstract class Student
    {
        //Sadece get methodları olacak.
        protected string name; 
        protected string surname;
        protected int no;
        public Student(string name, string surname, int no)
        {
            
        }


        public override string ToString()
        {
            return "Ad:___ Soyad:___ No:___ Tip:____"; 
        }

    }
}
