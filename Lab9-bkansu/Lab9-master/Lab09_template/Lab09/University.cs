using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab09
{
    [Serializable]
    class University
    {
        private string name;
        private List<Student> students = new List<Student> ();
        public List<Student> Students
        {
            get
            {
                return students;
            }
        }

        public University()
        {

        }
        public University(string name)
        {
            this.name = name;  
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public Student SearchStudent(string name)
        {
            Student t = null;
            bool flag = true;
            for (int i= 0; i < students.Capacity; i++)
            {
                t = students[i];
                if (t.Name == name)
                {
                    flag = false;
                    break;
                }
            }
            if (flag != false)
            {
                t = null; 
            }
            return t;

        }
     
        
        public Student SearchStudent(int no)
        {
            Student t = null;
            bool flag = true;
            for (int i = 0; i < students.Capacity; i++)
            {
                t = students[i];
                if (t.No == no)
                {
                    flag = false;
                    break;
                }
            }
            if (flag != false)
            {
                t = null;
            }
            return t;

        }


    }
}
