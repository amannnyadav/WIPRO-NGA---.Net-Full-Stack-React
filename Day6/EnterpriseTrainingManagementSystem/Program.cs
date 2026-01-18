// See https://aka.ms/new-console-template for more information
class Course
{
    public string Code { get; set; }
    public string Name { get; set; }

    public Course(string code, string name)
    {
        Code = code;
        Name = name;
    }
}

class EnrollmentRequest
{
    public int StudentId { get; set; }
    public string CourseCode { get; set; }

    public EnrollmentRequest(int sid, string code)
    {
        StudentId = sid;
        CourseCode = code;
    }
}

class Program
{
    static void Main()
    {
        // 1️ Manage Course Catalog (List)
        List<Course> courseCatalog = new List<Course>();
        courseCatalog.Add(new Course("CS101", "C# Basics"));
        courseCatalog.Add(new Course("DS201", "Data Structures"));

        Console.WriteLine("Course Catalog:");
        foreach (var c in courseCatalog)
            Console.WriteLine($"{c.Code} - {c.Name}");

        // 2️ Fast Course Lookup (Dictionary)
        Dictionary<string, Course> courseLookup = new Dictionary<string, Course>();
        foreach (var c in courseCatalog)
            courseLookup[c.Code] = c;

        Console.WriteLine("\nFast Lookup:");
        Console.WriteLine(courseLookup["DS201"].Name);

        // 3️ Avoid Duplicate Learner Enrollments (HashSet)
        HashSet<int> enrolledStudents = new HashSet<int>();
        enrolledStudents.Add(101);
        enrolledStudents.Add(102);
        enrolledStudents.Add(101);   // duplicate → ignored

        Console.WriteLine("\nUnique Enrollments:");
        foreach (var id in enrolledStudents)
            Console.WriteLine("Student ID: " + id);

        // 4️ Process Enrollment Requests in Order (Queue)
        Queue<EnrollmentRequest> requests = new Queue<EnrollmentRequest>();
        requests.Enqueue(new EnrollmentRequest(201, "CS101"));
        requests.Enqueue(new EnrollmentRequest(202, "DS201"));

        Console.WriteLine("\nProcessing Requests:");
        while (requests.Count > 0)
        {
            var r = requests.Dequeue();
            Console.WriteLine($"Processed: {r.StudentId} → {r.CourseCode}");
        }

        // 5 Display Sessions Sorted by Start Time (SortedList)
        SortedList<DateTime, string> sessions = new SortedList<DateTime, string>();
        sessions.Add(new DateTime(2026, 1, 14, 10, 0, 0), "C# Session");
        sessions.Add(new DateTime(2026, 1, 13, 9, 0, 0), "DS Session");

        Console.WriteLine("\nSessions by Time:");
        foreach (var s in sessions)
            Console.WriteLine($"{s.Key} → {s.Value}");
    }
}
