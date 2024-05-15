using LegolContactApp.Models.LegalContacts;
using System;

namespace LegolContactApp.Models.Managers
{
    public class Manager
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public LegalContact LegalContact { get; set; }
    }
}
