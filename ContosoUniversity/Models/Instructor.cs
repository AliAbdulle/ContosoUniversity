﻿using System;

namespace ContosoUniversity.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; } 

        public Department Department { get; set; }
    }
}