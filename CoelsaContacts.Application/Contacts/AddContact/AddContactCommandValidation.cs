using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoelsaContacts.Application.Contacts.AddContact
{
    class AddContactCommandValidation : AbstractValidator<AddContactCommand>
    {
        public AddContactCommandValidation()
        {
            RuleFor(t => t.Firstname).NotEmpty();
            RuleFor(t => t.LastName).NotEmpty();
            RuleFor(t => t.Company).NotEmpty();
            RuleFor(t => t.Email).NotEmpty();
            RuleFor(t => t.PhoneNumber).NotEmpty();
        }
    }
}
