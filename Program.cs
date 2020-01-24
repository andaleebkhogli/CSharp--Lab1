using Lab1;
using System;

namespace Lab1
{
    public enum position { Manager=1, Tech, Admin }
    public enum typeofjob { FullTime=1, PartTime }
    public struct Employee
    {
        public string name;
        public int id;
        public int salary;
        public position pos;
        public typeofjob type;
    }
  



    class Program
    {
        public static Employee Fill()
        {
            Employee emp;
            Console.WriteLine("Enter employee name");
            emp.name = Console.ReadLine();
            Console.WriteLine("Enter employee id");
            emp.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee salary");
            emp.salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee Position: 1-Manager 2-Technican 3-Admin");
            string pos1 = Console.ReadLine();
            emp.pos = (position)Convert.ToInt32(pos1);
            Console.WriteLine("Enter employee Job type: 1-FullTime 2-PartTime");
            string type1 = Console.ReadLine();
            emp.type = (typeofjob)Convert.ToInt32(type1);

            return emp;
        }

        public static void Display(Employee e)
        {
            Console.WriteLine("Employee: {0}", e.name);
            Console.WriteLine("Id: {0}", e.id);
            var salary = e.salary * 0.9;
            Console.WriteLine("Salary: {0}", salary);
            Console.WriteLine("Position: {0}", e.pos);
            Console.WriteLine("Type of job: {0}", e.type);
        }
        static void Main(string[] args)
        {

            Employee test;
            test = Fill();
            Display(test);

        }
    }

}