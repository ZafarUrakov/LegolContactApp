using LegolContactApp.Models.LegalContacts;
using System;
using System.Threading.Tasks;

namespace LegolContactApp.Services
{
    public interface ILegalContactService
    {
        ValueTask<LegalContact> RetrieveLegalContactById(Guid employeeId);
    }
}
