using FluentAssertions;
using Force.DeepCloner;
using LegolContactApp.Models.LegalContacts;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Service
{
    public partial class LegalContactServiceTests
    {
        [Fact]
        public async Task ShouldRetrieveLegalContactByEmployeeId()
        {
            // given
            LegalContact randomLegalContact = CreateRandomLegalContact();
            LegalContact storageLegalContact = randomLegalContact;
            LegalContact expectedLegalContact = storageLegalContact.DeepClone();
            Guid randomId = Guid.NewGuid();
            Guid inputEmployeeId = randomId;

            this.legalStorageBrokerMock.Setup(broker =>
                broker.GetDesignatedLegalContact(inputEmployeeId))
                    .Returns(null);

            this.legalStorageBrokerMock.

            // when
            LegalContact actualLegalContact = 
                await this.legalContactService.RetrieveLegalContactById(inputEmployeeId);

            // then
            actualLegalContact.Should().BeEquivalentTo(expectedLegalContact);

            this.legalStorageBrokerMock.Verify(broker =>
                broker.GetDesignatedLegalContact(inputEmployeeId), 
                    Times.Once());

            this.legalStorageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
