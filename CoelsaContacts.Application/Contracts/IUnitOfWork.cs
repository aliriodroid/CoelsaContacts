using System;
using System.Collections.Generic;
using System.Text;

namespace CoelsaContacts.Application.Contracts
{
    public interface IUnitOfWork
    {
        IContactRepository Contacts { get; }
    }
}
