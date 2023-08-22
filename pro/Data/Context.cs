﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using pro.Models;

namespace pro.Data
{
    public class Context : IdentityDbContext<User>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Acknowledgment> Acknowledgments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentUser> DepartmentUsers { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Skill> Skilluser { get; set; }




    }
}
