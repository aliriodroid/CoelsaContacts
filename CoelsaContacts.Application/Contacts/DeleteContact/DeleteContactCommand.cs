using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoelsaContacts.Application.Contacts.DeleteContact
{
    public class DeleteContactCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
