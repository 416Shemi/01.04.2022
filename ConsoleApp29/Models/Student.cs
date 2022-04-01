using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29.Models
{
    class Student
    {
        private int _id;
        public int Id { get;  }
        public string Fullname { get; set; }
        public int Point { get; set; }
        public Student(string fullname, int point)
        {
            Fullname = fullname;
            Point = point;
        }
        public Student()
        {
            _id = 0;
        }
        public Student(int _id)
        {
            _id++;
            Id = _id;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Id:{Id} Fullname:{Fullname} Point:{Point}");
        }
    }
}
