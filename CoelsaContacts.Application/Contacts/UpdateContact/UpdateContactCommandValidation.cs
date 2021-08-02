using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoelsaContacts.Application.Contacts.UpdateContact
{
    class UpdateContactCommandValidation: AbstractValidator<UpdateContactCommand>
    {
        public UpdateContactCommandValidation()
        {
            RuleFor(t => t.Firstname).NotEmpty();
            RuleFor(t => t.LastName).NotEmpty();
            RuleFor(t => t.Company).NotEmpty();
            RuleFor(t => t.Email).NotEmpty();
            RuleFor(t => t.PhoneNumber).NotEmpty();
        }
    }
}
