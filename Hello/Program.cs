List<Student> students = new List<Student>();
students.Add(new Student { Id = "1", name = "Alice", Age = 20, Gpa = 3.5m });
students.Add(new Student { Id = "2", name = "Bob", Age = 22, Gpa = 3.8m });
foreach (var student in students)
{
    Console.WriteLine($"Id: {student.Id}, Name: {student.name}, Age: {student.Age}, Gpa: {student.Gpa}");
}

// where students
students.Where(s => s.Age > 21).ToList().ForEach(s => Console.WriteLine($"Id: {s.Id}, Name: {s.name}, Age: {s.Age}, Gpa: {s.Gpa}"));