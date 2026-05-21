List<Student> students = [
    new Student { Id = "1", Name = "Alice", Age = 20, Gpa = 3.5m },
    new Student { Id = "2", Name = "Bob", Age = 22, Gpa = 3.9m },
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

// Output: Top student: Bob with GPA: 3.9
// select top 1 * from students order by gpa desc
// select * from students order by gpa desc limit 1
// select * from students order by gpa desc fetch first 1 rows only
var topStudent2 = students.OrderByDescending(s => s.Gpa).Take(1).FirstOrDefault();
if (topStudent2 != null)
{
    Console.WriteLine($"Top student: {topStudent2.Name} with GPA: {topStudent2.Gpa}");
}
else
{
    Console.WriteLine("No students found.");
}



// simple dictionary
var studentDict = students.ToDictionary(s => s.Id);
if (studentDict.TryGetValue("2", out var student))
{
    Console.WriteLine($"Found student: {student.Name} with GPA: {student.Gpa}");
}
else
{
    Console.WriteLine("Student not found.");
}