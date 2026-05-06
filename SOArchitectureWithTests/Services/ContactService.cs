using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Services.DtoModels;
using Services.Interfaces;

namespace Services
{
    public class ContactService(MyCRMContext context, ILogger<ContactService> logger) : IContactService
    {
        public async Task<bool> CreateContactAsync(string firstName, string lastName)
        {
            var newContact = new Contact(firstName, lastName);

            await context.Contacts.AddAsync(newContact);

            try
            {
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while creating the contact.");
                return false;
            }
        }

        public async Task<List<ContactDto>> GetAllContactsAsync()
        {
            List<Contact> contacts = await context.Contacts.Include(c => c.Account).ToListAsync();

            return contacts.Select(c => new ContactDto
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                FullName = c.FullName,
                Account = c.Account is not null ? new AccountDto
                {
                    Id = c.Account.Id,
                    Name = c.Account.Name,
                    FullName = c.Account.FullName,
                    ShortName = c.Account.ShortName
                } : null
            })
            .ToList();
        }

        public async Task<ContactDto?> GetContactByIdAsync(Guid id)
        {
            Contact? contact = await context.Contacts.FirstOrDefaultAsync(c => c.Id == id);

            if (contact is null)
            {
                return null;
            }

            return new ContactDto
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                FullName = $"{contact.FirstName} {contact.LastName}"
            };
        }
    }
}
