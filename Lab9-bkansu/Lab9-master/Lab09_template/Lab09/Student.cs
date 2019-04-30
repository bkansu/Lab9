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
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
        }        
        public int No
        {
            get
            {
                return no;
            }
        }
        public Student()
        {

        }
        public Student(string name, string surname, int no)
        {
            this.name = name;
            this.surname = surname;
            this.no = no;
        }


        public override string ToString()
        {
            return "Ad:___ Soyad:___ No:___ Tip:____"; 
        }

    }
}
