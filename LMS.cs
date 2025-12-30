using System;
using System.Collections.Generic;

namespace LibraryManagementSystem {

    // Class representing courses in the system
    class Courses
    {
        public string Id;           // Unique identifier for the course
        public string Title;        // Name of the course
        public string Description;  // Short description of the course
        
        // Method to display course details
        public void Display()
        {
            Console.WriteLine(Id + "-" + Title);
            Console.WriteLine("Description:" + " " + Description);
            Console.WriteLine();
        }
    }
    
    // Class representing students in the system
    class Students
    {
        public string studentId;    // Unique identifier for the student
        public string userName;     // Username for login
        
        // Method to display student details
        public void Display1 ()
        {
            Console.WriteLine( "Id: " + " " + studentId);
            Console.WriteLine("userName:" + " " + userName);
            Console.WriteLine();
        }
    }
    
    // Class representing enrollment records linking students to courses
    class Enrollments
    {
        public string studentId;       // ID of the student
        public string courseId;        // ID of the enrolled course
        public DateTime EnrollmentDate; // Date of enrollment
        
        // Method to display enrollment details
        public void Display2()
        {
            Console.WriteLine( "Id: " + " " + studentId);
            Console.WriteLine("CourseId:" + " " + courseId);
            Console.WriteLine("Enroll Date:" + " " + EnrollmentDate.ToString("yyyy-MM-dd"));
            Console.WriteLine();
        }
    }
    
    class Program
    {
        // List of all courses in the system
        static List <Courses> courses = new List <Courses> () 
        {
          new Courses { Id = "501", Title = "Tribology", Description = "Study of friction, wear, and lubrication in machines." },
          new Courses { Id = "509", Title= "Thermodynamics" , Description = "Principles governing energy, heat, and work."}, 
          new Courses { Id = "505", Title="Fluid Mechanics", Description = "Behavior of liquids and gases in motion and at rest."}, 
          new Courses { Id = "504", Title = "Heat Engines", Description = "Design and operation of engines converting heat to work." },
          new Courses { Id = "508", Title = "Transmission", Description = "Mechanisms for power transfer in machines and vehicle."} 
        };
        
        // List of all registered students
        static List <Students> students = new List <Students>()
        {
          new Students { studentId = "101", userName = "morola24"}, 
          new Students { studentId = "105", userName = "tomiwa36"}, 
          new Students { studentId = "201", userName = "funmilade77"},
          new Students { studentId = "301", userName = "tosin88"},
          new Students { studentId = "107", userName = "bolade33"}
        };
        
        // List of all course enrollments
        static List <Enrollments> enrollments = new List <Enrollments> ()
        {
          new Enrollments { studentId = "101", courseId = "501", EnrollmentDate = new DateTime(2025, 12, 20)}, 
          new Enrollments { studentId = "105", courseId = "509", EnrollmentDate = new DateTime(2025, 12, 21)}, 
          new Enrollments { studentId = "201", courseId = "508", EnrollmentDate = new DateTime(2025, 12, 23)},
          new Enrollments { studentId = "301", courseId = "504", EnrollmentDate = new DateTime(2025, 12, 25)},
          new Enrollments { studentId = "101", courseId = "505", EnrollmentDate = new DateTime(2025, 12, 27)}
        };
    
        // Method to display all available courses
        static void viewCourse ()
        {
            foreach (Courses c in courses)
            {
               c.Display(); 
            }
        }
        
        // Method to enroll the current user in a course
        static void enroll()
        {
            Console.WriteLine("........Enrollment section........");
            Console.WriteLine("Kindly enter the Course ID of the course you wish to register for.");
            string chosenCourse =  Console.ReadLine();
            
            // Find the selected course by ID
            Courses course = courses.Find(c => c.Id == chosenCourse);
            if (course == null)
            {
               Console.WriteLine("Course Id not found. Enrollment Failed!");
               return;
            }

            // Check if user is already enrolled
            bool alreadyEnrolled = enrollments.Exists(e=> e.studentId == currentUser.studentId && e.courseId == chosenCourse);
            if (alreadyEnrolled)
            {
              Console.WriteLine("You are already enrolled in this course.");
              return;
            }

            // Create a new enrollment record
            Enrollments newEnrollment = new Enrollments
            {
              studentId = currentUser.studentId,
              courseId = chosenCourse,
              EnrollmentDate = DateTime.Now
            };
          
            enrollments.Add(newEnrollment);
            Console.WriteLine("Enrollment Successful!");
        }
        
        // Method to register a new student
        static Students registration()
        {
            Console.WriteLine(".........Registration Section.........");
            Console.WriteLine("Please enter a username(must be your firstname and last two digits of your birth year).");
            string detailsName = Console.ReadLine().Trim();
            Console.WriteLine("Please enter your studentID");
            string detailsId = Console.ReadLine().Trim();

            // Validate input
            if ( !string.IsNullOrWhiteSpace(detailsName) && !string.IsNullOrWhiteSpace(detailsId) )
            {
                bool userNameExists =students.Exists(f => f.userName == detailsName);
                bool userIdExists =students.Exists(f => f.studentId == detailsId);
                if (userNameExists || userIdExists)
                {
                    Console.WriteLine("Username or Id already exists. Please try again.");
                    return null;
                }

                // Create and store new student
                Students newStudent = new Students
                {
                   studentId = detailsId,
                   userName = detailsName
                };
                students.Add(newStudent);
                Console.WriteLine("Registration Successful!");
                return newStudent;
            }
            else
            {
                Console.WriteLine("Please enter a valid username or student Id!");
                Console.WriteLine("");
                return null;
            }
        }
        
        // Method to display courses the current user is enrolled in
        static void myCourses()
        {
           Console.WriteLine(".......Course Section.......");
           var studentEnrollments = enrollments.FindAll(e=> e.studentId == currentUser.studentId);
           
           if (studentEnrollments.Count == 0)
           {
               Console.WriteLine("You are not enrolled in any courses.");
               return;
           }

           Console.WriteLine("Your enrolled courses are:");
           foreach (var enrollment in studentEnrollments)
           {
               Courses course = courses.Find(c=> c.Id == enrollment.courseId);
               if (course != null)
               {
                   course.Display();
               }
           }
        }
        
        // Holds the currently logged-in user
        static Students currentUser;
        
        // Handles user login and registration flow
        static bool Login()
        {
            Console.WriteLine ("Welcome to the Learning Management System.");
            Console.WriteLine("Login/Register(press l for login or r for register)");
            string user = Console.ReadLine().Trim().ToLower();

            if (user== "l")
            {
              Console.WriteLine("What is your username?");
              string userN = Console.ReadLine().Trim().ToLower();
              var storedUserNames = students.Find(f => f.userName == userN);
              if (storedUserNames != null)
              {
                  Console.WriteLine("Welcome Back, " + " " + userN + "!" );

