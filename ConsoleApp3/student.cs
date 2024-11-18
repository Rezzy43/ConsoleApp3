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
