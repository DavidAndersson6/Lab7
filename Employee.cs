using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Employee
    {
        public Employee(int id, string name, string gender, int salary)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary}";
        }
    }
}
