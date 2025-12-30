Project Description: Library / Learning Management System (Console-Based)

This project is a console-based Learning Management System (LMS) developed using C# and .NET, designed to simulate basic academic course management operations. The system allows students to register, log in, view available courses, enroll in courses, and view their enrolled courses through a menu-driven interface.

The application follows an object-oriented design approach, with separate classes representing core entities in the system: Courses, Students, and Enrollments. Data is stored in memory using generic lists, enabling efficient searching, validation, and management of records during program execution.

Upon launching the system, users are required to either log in with an existing username or register as a new student. The login process validates user credentials against stored student records, while the registration process ensures that duplicate usernames or student IDs are not allowed. Once authenticated, the user gains access to the main menu.

The system provides functionality to display all available courses, each with a course ID, title, and description. Students can enroll in courses by selecting a valid course ID. The system prevents duplicate enrollments by checking existing enrollment records before registering a new one. Each enrollment is recorded with the student ID, course ID, and enrollment date.

Additionally, students can view a personalized list of courses they are currently enrolled in. This is achieved by linking enrollment records with course data using matching IDs. The program maintains a single active user session during execution using a static currentUser reference.

Overall, this project demonstrates practical use of classes, objects, static methods, lists, conditional logic, and basic data validation in C#. It serves as a foundational example of how learning or library management systems operate at a basic level, focusing on clarity, functionality, and structured program flow.



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
