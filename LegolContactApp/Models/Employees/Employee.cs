using LegolContactApp.Models.LegalContacts;
using LegolContactApp.Models.Managers;
using System;

namespace LegolContactApp.Models.Employees
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Employee Manger { get; set; }
    }
}
