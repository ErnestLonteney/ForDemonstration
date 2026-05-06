using Services.DtoModels;

namespace Services.Interfaces
{
    public interface IContactService
    {
        Task<bool> CreateContactAsync(string firstName, string lastName);

        Task<ContactDto?> GetContactByIdAsync(Guid id);

        Task<List<ContactDto>> GetAllContactsAsync();

    }
}
