using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallenge3
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }

    }
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
    }
}