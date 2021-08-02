using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoelsaContacts.Application.Contacts.UpdateContact
{
    public class UpdateContactCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
