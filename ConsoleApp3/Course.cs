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