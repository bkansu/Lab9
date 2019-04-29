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
        private List<Student> students;

     
        public University(string name)
        {
           
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public Student SearchStudent(string name)
        {
            Student t = null;
           
            return t;
        }
     
        
        public Student SearchStudent(int no)
        {
            Student t = null;

            return t;
        }

       
    }
}
