using System;
using System.Collections.Generic;

public class Student
{
    // Properties added 
    public string Name { get; set; } // Student name
    public int ID { get; set; } // Student ID 
    public List<double> Grades { get; set; } // List of grades 

    // Constructor
    public Student()
    {
        Grades = new List<double>(); // Initialize Grades list
    }

    // Method to add a single grade
    public void AddGrade(double grade)
    {
        Grades.Add(grade); // Add grade to the list
    }

    // Overloaded method to add multiple grades using params
    public void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades); // Add multiple grades to the list
    }

    // Method to calculate average grade
    public double CalculateAverageGrade()
    {
        if (Grades.Count == 0)
            return 0; // I will return 0 if no grades are present

        double total = 0;
        foreach (var grade in Grades)
        {
            total += grade; // Sum of all grades
        }
        return total / Grades.Count; // Calculate average
    }
}

public class Course
{
    // Properties
    public string CourseName { get; set; }
    public string CourseCode { get; set; }

    // Field
    private List<Student> EnrolledStudents { get; set; }

    // Constructor
    public Course()
    {
        EnrolledStudents = new List<Student>(); // Initialize the list
    }

    // Method to enroll students in a course
    public void EnrollStudent(Student student)
    {
        if (!EnrolledStudents.Contains(student))
        {
            EnrolledStudents.Add(student); // Add student if not already enrolled
        }
        else
        {
            Console.WriteLine($"Student {student.Name} is already enrolled in the course.");
        }
    }

    // Method to display course information
    public void DisplayCourseInfo()
    {
        Console.WriteLine($"Course: {CourseName} ({CourseCode})");
        Console.WriteLine("Enrolled Students:");
        foreach (var student in EnrolledStudents)
        {
            Console.WriteLine($"- {student.Name} (ID: {student.ID})");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 4: Create a list of students
        List<Student> students = new List<Student>();

        // Step 5: Create instances of students
        Student student1 = new Student { Name = "Seth", ID = 1 };
        Student student2 = new Student { Name = "Miah", ID = 2 };
        Student student3 = new Student { Name = "Michael", ID = 3 };
        Student student4 = new Student { Name = "Nate", ID = 4 };

        // Step 6: Add students to the list
        students.Add(student1);
        students.Add(student2);
        students.Add(student3);
        students.Add(student4);

        // Step 7: Add grades
        student1.AddGrade(94.3);
        student1.AddGrade(90.0, 78.9, 95.4);

        student2.AddGrade(88.5);
        student2.AddGrade(92.3, 84.0);

        student3.AddGrade(70.0);
        student3.AddGrade(60.5, 75.3);

        student4.AddGrade(100.0);
        student4.AddGrade(98.9, 99.4);

        // Step 8: Display student information
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");
            Console.WriteLine("Grades: ");
            foreach (var grade in student.Grades)
            {
                Console.Write($"{grade} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Average Grade: {student.CalculateAverageGrade():F2}");
            Console.WriteLine();
        }

        // BONUS: Add a course
        Course course = new Course { CourseName = "Introduction to Programming", CourseCode = "CS101" };

        // Enroll students in the course
        course.EnrollStudent(student1);
        course.EnrollStudent(student2);
        course.EnrollStudent(student1); // Attempt to add duplicate

        // Display course information
        course.DisplayCourseInfo();
    }
}