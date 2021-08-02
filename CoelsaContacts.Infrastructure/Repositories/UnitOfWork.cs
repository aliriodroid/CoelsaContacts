using CoelsaContacts.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoelsaContacts.Infrastructure.Repositories
{
    class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IContactRepository contactRepository)
        {
            Contacts = contactRepository;
        }
        public IContactRepository Contacts { get; }
    }
}
