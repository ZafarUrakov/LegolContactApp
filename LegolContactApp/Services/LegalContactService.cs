using LegolContactApp.Brokers;
using LegolContactApp.Models.LegalContacts;
using System;
using System.Threading.Tasks;

namespace LegolContactApp.Services
{
    public class LegalContactService : ILegalContactService
    {
        private readonly ILegalContactBroker contactBroker;

        public LegalContactService(ILegalContactBroker contactBroker)
        {
            this.contactBroker = contactBroker;
        }

        public ValueTask<LegalContact> RetrieveLegalContactById(Guid employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
