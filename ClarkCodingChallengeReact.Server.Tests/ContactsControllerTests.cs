using ClarkCodingChallengeReact.Server.BusinessLogic;
using ClarkCodingChallengeReact.Server.Controllers;
using ClarkCodingChallengeReact.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ClarkCodingChallengeReact.Server.Tests
{
    [TestClass]
    public class ContactsControllerTests
    {
        private Mock<IContactsService> _contactsServiceMock;
        private ContactsController _contactsController;

        [TestInitialize]
        public void Startup()
        {
            _contactsServiceMock = new Mock<IContactsService>();
            _contactsController = new ContactsController(_contactsServiceMock.Object);
        }

        [TestMethod]
        public void ContactsController_CreateContact_ValidatesUserEmailDoesNotExist()
        {
            // Arrange
            _contactsServiceMock.Setup(service => service.VerifyEmail(It.IsAny<string>())).Returns(false);
            var contact = new Contact { Email = "Test@test.test", FirstName = "First", LastName = "Last" };

            // Act
            var result = _contactsController.CreateContact(contact);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
            var badRequest = result as BadRequestObjectResult;
            Assert.AreEqual("The following error(s) have occurred: Email is already in use.", badRequest?.Value);
        }
    }
}