using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                var student1 = new Student() { StudentName = "Tom Brady" };

                var course = new Course() { CourseName = "Aerodynamics" };
                var course2 = new Course() { CourseName = "Modeling Methods" };

                student1.CourseList.Add(course);
                student1.CourseList.Add(course2);

                db.Students.Add(student1);
                db.SaveChanges();
            }

        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public virtual List<Course> CourseList { get; set; }

        public Student()
        {
            this.CourseList = new List<Course>();
        }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public virtual Student Student { get; set; }
    }

    class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
