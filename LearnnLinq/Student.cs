using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnnLinq
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StEmail { get; set; }
        public string FullName { get; set; }
        public int Marks { get; set; }
        public List<Subject> Subject { get; set; }

    }

    public class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectMarks { get; set; }
    }
}
