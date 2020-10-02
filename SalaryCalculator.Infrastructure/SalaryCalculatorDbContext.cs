using Microsoft.EntityFrameworkCore;
using SalaryCalculator.Domain.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculator.Infrastructure
{
    public class SalaryCalculatorDbContext : DbContext
    {

        public SalaryCalculatorDbContext(DbContextOptions<SalaryCalculatorDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<SalaryCategory> SalaryCategories { get; set; }

        public DbSet<SatisfactoryScore> SatisfactoryScores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employees");
                entity.HasKey(x => x.Id);
                entity.HasOne(x => x.Manager).WithOne().HasForeignKey<Employee>(x => x.ManagerId).IsRequired(false);
                entity.HasMany(x => x.SatisfactoryScores).WithOne(x => x.Employee);
                entity.HasOne(x => x.Position).WithMany(x => x.Employees).HasForeignKey(x => x.PositionId);
                entity.HasOne(x => x.SalaryCategory).WithMany(x => x.Employees).HasForeignKey(x => x.SalaryCategoryId);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("Positions");
                entity.HasKey(x => x.Id);
            });

            modelBuilder.Entity<SalaryCategory>(entity =>
            {
                entity.ToTable("SalaryCategories");
                entity.HasKey(x => x.Id);
                entity.HasOne(x => x.Position).WithMany(x => x.SalaryCategories).HasForeignKey(x => x.PositionId);
            });

            modelBuilder.Entity<SatisfactoryScore>(entity =>
            {
                entity.ToTable("SatisfactoryScores");
                entity.HasKey(x => x.Id);
                entity.HasOne(x => x.Employee).WithMany(x => x.SatisfactoryScores).HasForeignKey(x => x.EmployeeId);
            });
        }
    }
}
