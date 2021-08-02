using CoelsaContacts.Application.Contracts;
using CoelsaContacts.Domain.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CoelsaContacts.Infrastructure.Repositories
{
    class ContactRepository : IContactRepository
    {
        private readonly IConfiguration _configuration;

        public ContactRepository(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        public async Task<int> Add(Contacts entity)
        {
            var sql = "INSERT INTO Contacts (Firstname, Lastname, Email, Company, PhoneNumber) Values (@Firstname, @LastName, @Email, @Company, @PhoneNumber);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }

        public async Task<int> Delete(int id)
        {
            var sql = "DELETE FROM Contacts WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, new { Id = id });
                return affectedRows;
            }
        }

        public async Task<IEnumerable<Contacts>> GetByCompany(string companyName,int pageIndex,int pageSize)
        {
            int offset = (pageIndex - 1) * pageSize;
            int next = pageSize;

            var sql = $"SELECT * FROM Contacts WHERE Company = @Company order by Firstname OFFSET {offset} ROWS FETCH NEXT {next} ROWS ONLY" ;

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Contacts>(sql, new { Company = companyName});
                return result;
            }
        }

        public async Task<int> Update(Contacts entity)
        {
            var sql = "UPDATE Contacts SET Firtsname = @FirstName, Lastname = @LastName, Company = @Company, Email = @Email, PhoneNumber = @PhoneNumber WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }
    }
}
