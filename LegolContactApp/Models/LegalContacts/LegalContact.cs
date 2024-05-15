using LegolContactApp.Models.Employees;
using LegolContactApp.Models.Managers;
using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace LegolContactApp.Models.LegalContacts
{
    public class LegalContact
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Collection<Manager> Managers{ get; set; }
    }
}
