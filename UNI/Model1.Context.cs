﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCHOOL_DATABASE
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UniversityContainer : DbContext
    {
        public UniversityContainer()
            : base("name=UniversityContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<CourseStudent> Courses { get; set; }
        public virtual DbSet<Teacher> TeacherSet { get; set; }
        public virtual DbSet<Course> CourseSet { get; set; }
        public virtual DbSet<Takes> TakesSet { get; set; }
    }
}
