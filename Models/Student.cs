﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tut3.Models
{
    public class Student
    {
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IndexNumber { get; set; }
        public string BirthDate { get; set; }
        public Enrollment enrollment { get; set; }

    }
}
