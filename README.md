Project Description: Library / Learning Management System (Console-Based)

This is a console-based Learning Management System (LMS) developed in C# on the .NET platform. It allows students to register, log in, view courses, enroll in courses, and view their enrolled courses through a simple menu-driven interface.

The system uses an object-oriented design with classes for Courses, Students, and Enrollments, storing data in in-memory lists for easy searching and validation. Registration prevents duplicate usernames or IDs, and enrollment prevents duplicate course registrations.

Students can view all available courses or their personalized enrolled courses. The application maintains a single active user session using a static currentUser reference.

This project demonstrates practical use of classes, objects, static members, lists, and conditional logic, providing a clear and functional example of a basic LMS system.

Full Flow
![Project Diagram](https://drive.google.com/file/d/1QnRWAFKoxflC1sJTjKROL5a3XQ7VGg7D/view?usp=drive_link)

Login and registration flow
![Project Diagram](https://drive.google.com/file/d/1OJYw4ZzAJhBO2-5YmO_ltGE96V17NbK4/view?usp=drive_link)

Enroll Flow
![Project Diagram](https://drive.google.com/file/d/1p6gMIC541QQEwjMZL38VaYLLHjilPZYA/view?usp=drive_link)

LMS (LEARNING MANAGEMENT SYSTEM)

Build a console application that allows users to view a catalog of courses and enroll in them.

FOCUS: Object-Oriented Programming (OOP) principles and in-memory data management.

Functional Requirements

The application must perform the following actions upon startup:

1. Initialize Data:
Create a hard-coded List<Course> containing at least 5 sample courses.

2. User Login (Mock):
Prompt the user to enter their name to "log in" as a student.

3. Main Menu:
Display a loop that stays open until the user chooses to "Exit."

Option 1: View All Courses:
Print a formatted list of all available courses to the console.

Option 2: Enroll in Course:
Prompt the user for a Course ID, then create an Enrollment object and add it to a "Master Enrollment List."

Option 3: View My Courses:
Filter the enrollment list to show only the courses the current user has joined.

Option 4: Exit:
Close the application.

Expected Models Class

Student (id, name)

Course (id, title, desc)

Class (StudentId, CourseId, EnrollDate)
