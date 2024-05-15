using LegolContactApp.Models.Employees;
using LegolContactApp.Models.LegalContacts;
using System;
using System.Threading.Tasks;

namespace LegolContactApp.Brokers
{
    public interface ILegalContactBroker
    {
        ValueTask<LegalContact> GetDesignatedLegalContact(Guid empoyeeId);
        ValueTask<Employee> GetEmployeeById(Guid managerId);
    }
}
