List<Student> students = [
    new Student {Id="S1",Name="Surafel",Age=23,GPA=3.45m},
    new Student {Id="S2",Name="Abel",Age=24,GPA=3.08m},
    new Student {Id="S3",Name="Henok",Age=20,GPA=2.4m},
    new Student {Id="S4",Name="Yared",Age=34,GPA=2.87m},
    new Student {Id="S1",Name="Aster",Age=23,GPA=3.45m},
];

// excute the val
var info = students.OrderByDescending(s => s.GPA);
foreach (var student in info)
    Console.WriteLine($"The students = name: {student.Name}");

    const decimal pi = 3.14m;
    