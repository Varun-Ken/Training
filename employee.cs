using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Employee
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public int Age { get; set; }
       public int Salary{ get; set; }


        public Employee(int id, string name, int age, int salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
        }

        public void EmployeeDetails()
        {
            Console.WriteLine("Id :" + this.Id);
            Console.WriteLine("Name :" +this.Name);
            Console.WriteLine("Age :" + this.Age);
            Console.WriteLine("Salary :" + this.Salary);
            Console.WriteLine("________________________");
        }
    }

}
