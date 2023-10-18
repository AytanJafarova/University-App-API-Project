using Core.Enums;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.UniversityDbContext
{
    public class UniDbContext :DbContext
    {
        public UniDbContext(DbContextOptions<UniDbContext> options):base(options)
        {
            
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<PreExam> PreExams { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Exam>()
            //.HasOne(exam => exam.Grade)
            //.WithOne(grade => grade.Exam)
            //.HasForeignKey<Grade>(grade => grade.ExamId);

            // modelBuilder.Entity<PreExam>()
            //.HasOne(preexam => preexam.Grade)
            //.WithOne(grade => grade.PreExam)
            //.HasForeignKey<Grade>(grade => grade.PreExamId);

            modelBuilder.Entity<Account>()
          .HasIndex(e => e.Username)
          .IsUnique();

            modelBuilder.Entity<Course>()
           .HasIndex(e => e.Title)
           .IsUnique();

            modelBuilder.Entity<Department>()
           .HasIndex(e => e.DepartmentName)
           .IsUnique();

            modelBuilder.Entity<Status>().HasData(
                new Status()
                {
                    StatusId = 1,
                    StatusName = "ADMIN",
                    Key = EAccountStatus.admin.ToString(),
               },
                 new Status()
                 {
                     StatusId = 2,
                     StatusName = "TEACHER",
                     Key = EAccountStatus.teacher.ToString(),
                 },
                  new Status()
                  {
                      StatusId = 3,
                      StatusName = "STUDENT",
                      Key = EAccountStatus.student.ToString(),
                  }
              );

            modelBuilder.Entity<Department>().HasQueryFilter(m => m.IsDeleted == false || m.IsDeleted == null);
            modelBuilder.Entity<Account>().HasQueryFilter(m => m.IsDeleted == false || m.IsDeleted == null);
            modelBuilder.Entity<Student>().HasQueryFilter(m => m.IsDeleted == false || m.IsDeleted == null);
            modelBuilder.Entity<Teacher>().HasQueryFilter(m => m.IsDeleted == false || m.IsDeleted == null);
            modelBuilder.Entity<Grade>().HasQueryFilter(m => m.IsDeleted == false || m.IsDeleted == null);
            modelBuilder.Entity<Group>().HasQueryFilter(m => m.IsDeleted == false || m.IsDeleted == null);
            modelBuilder.Entity<Enrollment>().HasQueryFilter(m => m.IsDeleted == false || m.IsDeleted == null);
            modelBuilder.Entity<Exam>().HasQueryFilter(m => m.IsDeleted == false || m.IsDeleted == null);
            modelBuilder.Entity<PreExam>().HasQueryFilter(m => m.IsDeleted == false || m.IsDeleted == null);
            modelBuilder.Entity<Course>().HasQueryFilter(m => m.IsDeleted == false || m.IsDeleted == null);
            base.OnModelCreating(modelBuilder);

        }
    }
}
