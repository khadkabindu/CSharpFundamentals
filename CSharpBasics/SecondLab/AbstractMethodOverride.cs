namespace CSharpBasics;
// program with abstract class, showing abstract method override in child class
public class AbstractMethodOverride
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Awantika");
        Console.WriteLine(student1);
    }
}

abstract class Person
{
    private string name; 
    public abstract void Work();
}

partial class Student : Person
{
    private string name;
    public Student(string name)
    {
        this.name = name;
    } 
    
    
    public override void Work()
    {
        Console.WriteLine("I don't work, I study to get work so that's my work");
    }
}
