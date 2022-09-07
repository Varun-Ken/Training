using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Hari = new Employee(888123, "HarI", 42, 1000);
            Employee Dhoni = new Employee(423432, "dhoni", 32, 59000);
            Employee Frank = new Employee(561654, "FraNk", 23, 60000);
            Employee Sanjay = new Employee(455654, "SANJAY", 43, 40000);



           List<Employee> EmployeeList = new List<Employee>();

            EmployeeList.Add(Hari);
            EmployeeList.Add(Dhoni);
            EmployeeList.Add(Frank);
            EmployeeList.Add(Sanjay);

            //Console.Write("ID:");
            //int id=Int32.Parse(Console.ReadLine());

            //Console.Write("Name:");
            //String name = Console.ReadLine();

            //Console.Write("Age:");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Salary:");
            //int salary = Convert.ToInt32(Console.ReadLine());


            //Employee user1 = new Employee(id, name, age, salary);
            //EmployeeList.Add(user1);

            //foreach (Employee e in EmployeeList)
            //{
            //    e.EmployeeDetails();
            //}

            var order = from x in EmployeeList
                        orderby x.Name ascending
                        select x;

            foreach (Employee x in order)
            {
                x.EmployeeDetails();
            }

            //Console.Write("Enter the Employee Name :"); 
            //string un = Console.ReadLine();


            //Filtration

            /*var oldie = from x in EmployeeList
                        where (x.Name).ToLower() == un.ToLower()
                        select x;

            foreach(Employee x in oldie)
            {
                x.EmployeeDetails();
            } */

        }
    }
}
