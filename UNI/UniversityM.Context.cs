﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UNI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UniversityEntities : DbContext
    {
        public UniversityEntities()
            : base("name=UniversityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<advisor> advisors { get; set; }
        public virtual DbSet<classroom> classrooms { get; set; }
        public virtual DbSet<course> courses { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<instructor> instructors { get; set; }
        public virtual DbSet<prereq> prereqs { get; set; }
        public virtual DbSet<section> sections { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<take> takes { get; set; }
        public virtual DbSet<teach> teaches { get; set; }
        public virtual DbSet<time_slot> time_slot { get; set; }
    }
}
