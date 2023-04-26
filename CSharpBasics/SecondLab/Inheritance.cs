namespace CSharpBasics;

public class Inheritance
{
    // static void Main(string[] args)
    // {
    //     Dog dog1 = new Dog("tommy");
    //     Console.WriteLine("Hi I am "+ dog1.DisplayName());
    //     Console.WriteLine(dog1.Eat());
    // }
}


public class Animal
{
    private string Name;
    public string Eat()
    {
        return "I eat food to survive";
    }
        
        
}

public class Dog : Animal
{
    private string Name;
    public Dog(string name)
    {
        Name = name;
    }
    public string DisplayName()
    {
        return Name;
    }
}