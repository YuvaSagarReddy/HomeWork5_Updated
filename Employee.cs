using System;
namespace Homework_5
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string aname, double asalary)
        {
            Name = aname;
            Salary = asalary;
        }

        public override string ToString()
        {
            return $"Employee: {Name}, Salary: ${Salary}";
        }
    }

    public class Manager:Employee
    {
        public int NOEM { get; set; }

        public Manager(string name, double salary, int noem): base(name, salary)
        {
            NOEM = noem;
        }
        public override string ToString()
        {
            return $"Employee: {Name}, Salary: ${Salary}, Manages: {NOEM} employees";
        }
    }

    public class Engineer:Employee
    {
        public string Specialization { get; set; }

        public Engineer(string name, double salary, string specialization): base(name, salary)
        {
            Specialization = specialization;
        }
        public override string ToString()
        {
            return $"Employee: {Name}, Salary: ${Salary}, Specialization: {Specialization}";
        }
    }
}

