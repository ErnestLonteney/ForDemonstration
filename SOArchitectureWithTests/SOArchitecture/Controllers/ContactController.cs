using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SOArchitecture.Models;

namespace SOArchitecture.Controllers
{
    public class ContactController(IContactService contactService) : Controller
    {
        public async Task<IActionResult> List()
        {
            var result = await contactService.GetAllContactsAsync();

            if (result.Any())
            {
                var contactsVM = result.Select(c => new ContactViewModel
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Account = new AccountViewModel
                    {
                        Name = c.Account?.FullName ?? string.Empty 
                    }
                }).ToList();

                return View(contactsVM);
            }

            return NotFound();
        }

        
    }
}
