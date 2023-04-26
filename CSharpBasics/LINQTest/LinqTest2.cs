namespace CSharpBasics.LINQTest;

public class LinqTest2
{
    // static void Main(string[] args)
    // {
    //     IList<Student> studentList = new List<Student>()
    //     { 
    //         new Student(){ StudentID = 1, StudentName = "Sakina", Age = 20},
    //         new Student(){ StudentID =2, StudentName = "Asmita", Age = 16}
    //     };
    //
    //     var teen = from s in studentList where s.Age > 12 && s.Age == 20 select s;
    //
    //     foreach (Student std in teen)
    //     {
    //         Console.WriteLine(std.StudentName);
    //     }
    //
    // }
}

public class Student
{
     public int StudentID { get; set; }
     public string StudentName { get; set; }
     public int Age { get; set; }
} 

