using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleOefeningweek1Blok22023
{
    internal class Oefening2
    {

        public class University
        {
            public string UniName { get; set; }
            public List<UniStudent> Students { get; set; } = new List<UniStudent>();
            public List<Course> Courses { get; set; } = new List<Course>();

            public void RegisterStudent(UniStudent naam)
            { 
                Students.Add(naam);
            }

            public void OfferCourse(Course naam)
            {
                Courses.Add( naam);
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Deze studenten zijn ingeschreven op {UniName}:");
                foreach(var student in Students)
                {
                    Console.WriteLine($"{student.UniStudentName} en doet mee met:");
                    foreach (var course in student.Courses)
                    {
                        Console.WriteLine($"{course.UniCourseName}"); 
                    }
                }
            }
            
        }

        public class UniStudent
        {
            public string UniStudentName { get; set; }
            public List<Course> Courses { get; set; } = new List<Course>();
            
            public void EnrollInCourse(Course course)
            {
                Courses.Add(course);
                course.students.Add(this);

            }

            public void ShowInfo()
            {
                
                    Console.WriteLine($"{UniStudentName} en doet mee met:");
                    foreach (var course in Courses)
                    {
                        Console.WriteLine($"{course.UniCourseName}");
                    }
                
            }




        }

        public class Course
        {
            public string UniCourseName { get; set; }
            public List<UniStudent> students { get; set; } = new List<UniStudent>();

            public void ShowInfo()
            {
                
                    Console.WriteLine($"{UniCourseName} heeft de volgende deelnemers:");
                    foreach (var student in students)
                    {
                        Console.WriteLine($"{student.UniStudentName}");
                    }
                
            }

        }
    }
}
