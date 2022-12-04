using ContactsAPI.Data;
using ContactsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly ContactsAPIDbContext dbContext;

        public ContactsController(ContactsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {
            return Ok(await dbContext.Contacts.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddContact(AddContactRequest addContacts)
        {
            var contact = new Contact
            {
                Id = Guid.NewGuid(),
                FullName = addContacts.FullName,
                Email = addContacts.Email,
                Phone = addContacts.Phone,
                Address = addContacts.Address
            };

            await dbContext.Contacts.AddAsync(contact);
            await dbContext.SaveChangesAsync();

            return Ok(contact);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateContact(Guid id, UpdateContactRequest updateContactRequest)
        {
            var contact = await dbContext.Contacts.FindAsync(id);

            if (contact is null)
                return NoContent();

            contact.FullName = updateContactRequest.FullName;
            contact.Email = updateContactRequest.Email;
            contact.Address = updateContactRequest.Address;
            contact.Phone = updateContactRequest.Phone;

            await dbContext.SaveChangesAsync();

            return Ok(contact);
        }
    }
}
