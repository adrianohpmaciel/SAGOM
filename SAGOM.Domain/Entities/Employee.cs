using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Employee
    {
        public int Id { get; private set; }
        public Role Role { get; private set; }
        public Person Person { get; private set; }
        public double Salary { get; private set; }

        public Employee (int id, Role role, Person person, double salary)
        {
            Id = id;
            Role = role;
            Person = person;
            Salary = salary;
        }   
    }
}
