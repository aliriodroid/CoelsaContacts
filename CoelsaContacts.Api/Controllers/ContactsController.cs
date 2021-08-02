using CoelsaContacts.Application.Contacts.AddContact;
using CoelsaContacts.Application.Contacts.DeleteContact;
using CoelsaContacts.Application.Contacts.DTO;
using CoelsaContacts.Application.Contacts.GetContactsList;
using CoelsaContacts.Application.Contacts.UpdateContact;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoelsaContacts.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(AddContactCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<ActionResult<List<ContactDto>>> GetByCompany(string company, int pageIndex, int pageSize)
        {
            return await Mediator.Send(new GetContactListQuery(company, pageIndex, pageSize));
        }


        [HttpPut]
        public async Task<ActionResult<int>> Update(UpdateContactCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete]
        public async Task<ActionResult<int>> Delete(int id)
        {
            return await Mediator.Send(new DeleteContactCommand { Id = id });
        }
    }
}
