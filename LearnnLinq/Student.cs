﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnnLinq
{
    internal class Student
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string? StEmail { get; set; }
        public string? FullName { get; set; }
        public int Marks { get; set; }
        public List<Subject>? Subject { get; set; }

        public string? Name { get; set; }
        public int? AddressId { get; set; }
        public int? CategoryId { get; set; }

    }

    public class Subject
    {
        public string? SubjectName { get; set; }
        public int SubjectMarks { get; set; }
    }
}
