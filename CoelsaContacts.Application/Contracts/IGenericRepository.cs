using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoelsaContacts.Application.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<int> Add(T entity);
        Task<int> Delete(int id);
        Task<int> Update(T entity);
    }
}
