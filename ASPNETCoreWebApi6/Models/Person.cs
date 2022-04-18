﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ASPNETCoreWebApi6.Models
{
    public partial class Person
    {
        public Person()
        {
            Department = new HashSet<Department>();
            Enrollment = new HashSet<Enrollment>();
            Course = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public string Discriminator { get; set; }

        public virtual OfficeAssignment OfficeAssignment { get; set; }
        public virtual ICollection<Department> Department { get; set; }
        public virtual ICollection<Enrollment> Enrollment { get; set; }

        public virtual ICollection<Course> Course { get; set; }
    }
}