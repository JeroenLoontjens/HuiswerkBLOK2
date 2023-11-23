using static ConsoleOefeningweek1Blok22023.Oefening2;
using static ConsoleOefeningweek1Blok22023.Oefening3;

namespace ConsoleOefeningweek1Blok22023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Jeroen = new Student { Name = "ALice", Age = 20, StudentID = "S12345" };
            Teacher Marcel = new Teacher { Name = "Mr. Smith", Age = 35, Subject = "Math" };
            Jeroen.DisplayInfo();
            Marcel.DisplayInfo();

            //----------OEFENING 2---------------------------------------

            University myUniversity = new University { UniName = "HogeSchoolZuyd"};
            UniStudent Student1 = new UniStudent { UniStudentName = "Alice" };
            Course mathCourse = new Course { UniCourseName = "Mathematics" };
            myUniversity.RegisterStudent(Student1);
            myUniversity.OfferCourse(mathCourse);
            Student1.EnrollInCourse(mathCourse);

            //__________________EXTRA__________________________________________
            
            myUniversity.ShowInfo();
            mathCourse.ShowInfo();

            //__________OEFENING 3______________________________________________

            Engine CarEngine = new Engine { Model = "V6", name = "HOR" };
            Car MyCar = new Car { Make = "TOYOTA", Model= "CAMRY", CarEngine = CarEngine };
            Driver driver = new Driver { Name = "Alice", Age = 30, DriverCar = MyCar };
            driver.StartCar();
            driver.DriverCar.Drive();
            driver.DriverCar.Honk();
            driver.StopCar();

        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string StudentID { get; set; }

       
        

        public void DisplayInfo()
        {
            string tekst = $"{Name} {Age} {StudentID}";
            Console.WriteLine(tekst);  
        }

        public void Study()
        {
            
        }
    }



    public class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Subject { get; set; }

        public void DisplayInfo()
        {
            string tekst = Name + " " + Age + " " + Subject;
            Console.WriteLine(tekst);
        }

        public void Teach()
        {

        }

    }
}