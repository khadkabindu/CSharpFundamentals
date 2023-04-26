
using CSharpBasics;



namespace CSharpBasics
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private double salary;

        public string firstname
        {
            get { return firstName; }
        }

        public string lastname
        {
            get { return lastName; }
        }

        public double getSalary
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

        double incrementSalary(double increment)
        {
            return salary + increment;
        }
        
        
        void Main(string[] args)
        {
            Employee employee1 = new Employee("ram","khadka",10000.0);
            Console.WriteLine(employee1.firstname);
            Console.WriteLine(employee1.lastname);
    

    
        }
    } 
    
    
}

