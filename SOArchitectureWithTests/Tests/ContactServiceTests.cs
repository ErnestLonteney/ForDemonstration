using DataAccess.Entities;
using NUnit.Framework;
using Services;
using Services.DtoModels;
using Tests.Fixtures;

namespace Services.UnitTests
{
    [TestFixture]
    public class ContactServiceTests : TestFixtureBase
    {
        private ContactService _contactService = null!;
        private MyCRMContext _context = null!;

        [SetUp]
        public void Setup()
        {
            _context = GetInMemoryContext();
            var logger = GetMockLogger<ContactService>();
            _contactService = new ContactService(_context, logger);
        }

        [TearDown]
        public void TearDown()
        {
            _context?.Dispose();
        }

        #region CreateContactAsync Tests

        [Test]
        public async Task CreateContactAsync_WithValidData_ShouldReturnTrue()
        {
            // Arrange
            const string firstName = "John";
            const string lastName = "Doe";

            // Act
            var result = await _contactService.CreateContactAsync(firstName, lastName);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task CreateContactAsync_WithValidData_ShouldSaveContactToDatabase()
        {
            // Arrange
            const string firstName = "Jane";
            const string lastName = "Smith";

            // Act
            await _contactService.CreateContactAsync(firstName, lastName);
            var contacts = await _contactService.GetAllContactsAsync();

            // Assert
            Assert.That(contacts, Has.Count.EqualTo(1));
            Assert.That(contacts[0].FirstName, Is.EqualTo(firstName));
            Assert.That(contacts[0].LastName, Is.EqualTo(lastName));
        }

        [Test]
        public async Task CreateContactAsync_WithValidData_ShouldGenerateUniqueId()
        {
            // Arrange
            const string firstName = "Bob";
            const string lastName = "Johnson";

            // Act
            await _contactService.CreateContactAsync(firstName, lastName);
            var contacts = await _contactService.GetAllContactsAsync();

            // Assert
            Assert.That(contacts[0].Id, Is.Not.EqualTo(Guid.Empty));
        }

        [Test]
        public async Task CreateContactAsync_WithMultipleContacts_ShouldSaveAllContacts()
        {
            // Arrange
            var contactsToAdd = new[]
            {
                ("Alice", "Brown"),
                ("Charlie", "Davis"),
                ("Diana", "Evans")
            };

            // Act
            foreach (var (firstName, lastName) in contactsToAdd)
            {
                await _contactService.CreateContactAsync(firstName, lastName);
            }
            var contacts = await _contactService.GetAllContactsAsync();

            // Assert
            Assert.That(contacts, Has.Count.EqualTo(3));
        }

        [Test]
        public async Task CreateContactAsync_WithEmptyFirstName_ShouldStillCreate()
        {
            // Arrange - testing edge case
            const string firstName = "";
            const string lastName = "Test";

            // Act
            var result = await _contactService.CreateContactAsync(firstName, lastName);
            var contacts = await _contactService.GetAllContactsAsync();

            // Assert
            Assert.That(result, Is.True);
            Assert.That(contacts, Has.Count.EqualTo(1));
        }

        #endregion

        #region GetAllContactsAsync Tests

        [Test]
        public async Task GetAllContactsAsync_WithNoContacts_ShouldReturnEmptyList()
        {
            // Act
            var result = await _contactService.GetAllContactsAsync();

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task GetAllContactsAsync_WithMultipleContacts_ShouldReturnAllContacts()
        {
            // Arrange
            await _contactService.CreateContactAsync("Frank", "Garcia");
            await _contactService.CreateContactAsync("Grace", "Harris");
            await _contactService.CreateContactAsync("Henry", "Jackson");

            // Act
            var result = await _contactService.GetAllContactsAsync();

            // Assert
            Assert.That(result, Has.Count.EqualTo(3));
        }

        [Test]
        public async Task GetAllContactsAsync_ShouldReturnContactDto()
        {
            // Arrange
            await _contactService.CreateContactAsync("Iris", "King");

            // Act
            var result = await _contactService.GetAllContactsAsync();

            // Assert
            Assert.That(result[0], Is.InstanceOf<ContactDto>());
            Assert.That(result[0].FirstName, Is.EqualTo("Iris"));
            Assert.That(result[0].LastName, Is.EqualTo("King"));
        }

        [Test]
        public async Task GetAllContactsAsync_ShouldMapFullName()
        {
            // Arrange
            await _contactService.CreateContactAsync("Jack", "Lee");

            // Act
            var result = await _contactService.GetAllContactsAsync();

            // Assert
            Assert.That(result[0].FullName, Is.EqualTo("Jack Lee"));
        }

        #endregion

        #region GetContactByIdAsync Tests

        [Test]
        public async Task GetContactByIdAsync_WithValidId_ShouldReturnContact()
        {
            // Arrange
            await _contactService.CreateContactAsync("Karen", "Miller");
            var allContacts = await _contactService.GetAllContactsAsync();
            var contactId = allContacts[0].Id;

            // Act
            var result = await _contactService.GetContactByIdAsync(contactId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result!.FirstName, Is.EqualTo("Karen"));
            Assert.That(result.LastName, Is.EqualTo("Miller"));
        }

        [Test]
        public async Task GetContactByIdAsync_WithInvalidId_ShouldReturnNull()
        {
            // Arrange
            var invalidId = Guid.NewGuid();

            // Act
            var result = await _contactService.GetContactByIdAsync(invalidId);

            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetContactByIdAsync_ShouldReturnContactDto()
        {
            // Arrange
            await _contactService.CreateContactAsync("Larry", "Nelson");
            var allContacts = await _contactService.GetAllContactsAsync();
            var contactId = allContacts[0].Id;

            // Act
            var result = await _contactService.GetContactByIdAsync(contactId);

            // Assert
            Assert.That(result, Is.InstanceOf<ContactDto>());
        }

        [Test]
        public async Task GetContactByIdAsync_ShouldMapFullNameCorrectly()
        {
            // Arrange
            await _contactService.CreateContactAsync("Mary", "O'Connor");
            var allContacts = await _contactService.GetAllContactsAsync();
            var contactId = allContacts[0].Id;

            // Act
            var result = await _contactService.GetContactByIdAsync(contactId);

            // Assert
            Assert.That(result!.FullName, Is.EqualTo("Mary O'Connor"));
        }

        [Test]
        public async Task GetContactByIdAsync_WithEmptyGuid_ShouldReturnNull()
        {
            // Act
            var result = await _contactService.GetContactByIdAsync(Guid.Empty);

            // Assert
            Assert.That(result, Is.Null);
        }

        #endregion
    }
}
