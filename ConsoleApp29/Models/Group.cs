using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29.Models
{
    class Group
    {
        public string GroupNo { get; set; }
        public int StudentLimit 
        {
            get
            {
                return StudentLimit;
            }
            set
            {
                if (value>=5 || value<=18)
                {
                    StudentLimit = value;
                }

            }
        }
        private Students[] _students = new Students[0];
        public int MyProperty { get; set; }
        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }

        public bool CheckGroupNo(string GroupNo)
        {
            if ( GroupNo.Length==5 && string.IsNullOrEmpty(GroupNo) && string.IsNullOrWhiteSpace(GroupNo))
            {
                bool isDigit = false;
                bool isLawer = false;
                foreach (var item in GroupNo)
                {
                    if (char.IsDigit(item))
                    {
                        isDigit = true;
                    }
                    else if (char.IsLower(item))
                    {
                        isLawer = true;
                    }
                    if (isDigit && isLawer)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = student;
        }
        public void GetStudent(StudentId==Null)
        {

        }
    }
}
