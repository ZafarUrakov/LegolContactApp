using LegolContactApp.Brokers;
using LegolContactApp.Models.Employees;
using LegolContactApp.Models.LegalContacts;
using LegolContactApp.Services;
using Moq;
using Tynamix.ObjectFiller;

namespace TestProject.Service
{
    public partial class LegalContactServiceTests
    {
        private readonly Mock<ILegalContactBroker> legalStorageBrokerMock;
        private readonly ILegalContactService legalContactService;

        public LegalContactServiceTests()
        {
            this.legalStorageBrokerMock = new Mock<ILegalContactBroker>();

            this.legalContactService = 
                new LegalContactService(legalStorageBrokerMock.Object);
        }

        private Filler<LegalContact> CreateRandomFiller() =>
            new Filler<LegalContact>();

        private LegalContact CreateRandomLegalContact() =>
            CreateRandomFiller().Create();
        
        private Filler<Employee> CreateRandomFiller() =>
            new Filler<Employee>();

        private Employee CreateRandomLegalContact() =>
            CreateRandomFiller().Create();
    }
}
