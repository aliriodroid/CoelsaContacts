using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoelsaContacts.Domain.Entities;

namespace CoelsaContacts.Application.Contracts
{
    public interface IContactRepository : IGenericRepository<Domain.Entities.Contacts>
    {
        Task<IEnumerable<Domain.Entities.Contacts>> GetByCompany(string companyName, int offset, int next);
    }
}
