namespace CSharpBasics;

public class classAndObject
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private double salary;

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public double GetSalary
        {
            get { return salary; }
        }

        public Employee(string firstName, string lastName, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }



        string ShowFullName()
        {
            return firstName + lastName;
        }

        double IncrementSalary(double increment)
        {
            return salary + increment;
        }

        string  ReplaceName(string replaceName)
        {
            var replace = FirstName.Replace(FirstName, replaceName);
            return replace;
        }


        // static void Main(string[] args)
        // {
        //     Employee employee1 = new Employee("ram","Bahadur",20000.0);
        //     Console.WriteLine(employee1.ShowFullName());
        //     Console.WriteLine(employee1.salary);
        //     Console.WriteLine("Replaced Name: " + employee1.ReplaceName("hari")+ employee1.lastName);
        //     Console.WriteLine(employee1.IncrementSalary(5000));
        //     
        // }


    }

}