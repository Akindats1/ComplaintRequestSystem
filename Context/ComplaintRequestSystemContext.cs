﻿using ComplaintRequestSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ComplaintRequestSystem.Context
{
    public class ComplaintRequestSystemContext : DbContext
    {
        public ComplaintRequestSystemContext(DbContextOptions<ComplaintRequestSystemContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((BaseEntity)entry.Entity).DateCreated = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                    ((BaseEntity)entry.Entity).LastModified = DateTime.Now;
            }

            foreach (var entry in ChangeTracker.Entries().Where(e => e.Entity is ISoftDeletable && e.State == EntityState.Deleted))
            {
                entry.State = EntityState.Modified;
                entry.CurrentValues["IsDeleted"] = true;
            }

            return base.SaveChanges();
        }

        public DbSet<User> Users { get; set; }  
        public DbSet<Role> Roles { get; set; }  
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentComplaint> DepartmentComplaints { get; set; }
        public DbSet<DepartmentRequest> DepartmentRequests { get; set; }

    }
}
