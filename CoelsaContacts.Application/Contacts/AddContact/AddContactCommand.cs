using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoelsaContacts.Application.Contacts.AddContact
{
    public class AddContactCommand: IRequest<int>
    {
        public string Firstname { get;  set; }
        public string LastName { get;  set; }
        public string Company { get;  set; }
        public string Email { get;  set; }
        public string PhoneNumber { get;  set; }
    }
}
