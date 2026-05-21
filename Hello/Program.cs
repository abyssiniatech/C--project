List<Student> students = [
    new Student { Id = "1", Name = "Alice", Age = 20, Gpa = 3.5m },
    new Student { Id = "2", Name = "Bob", Age = 22, Gpa = 3.8m },
    new Student { Id = "3", Name = "Charlie", Age = 19, Gpa = 3.2m }

];
var topStudent = students.OrderByDescending(s => s.Gpa).FirstOrDefault();
if (topStudent != null)
{
    Console.WriteLine($"Top student: {topStudent.Name} with GPA: {topStudent.Gpa}");
}
else
{
    Console.WriteLine("No students found.");
}

