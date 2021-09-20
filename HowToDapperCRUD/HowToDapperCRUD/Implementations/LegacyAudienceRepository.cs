using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HowToDapperCRUD.Contracts;
using HowToDapperCRUD.Entities;
using Microsoft.Extensions.Configuration;

namespace HowToDapperCRUD.Implementations
{
    public class LegacyAudienceRepository: IAudienceRepository
    {
        private readonly SqlConnection _connection;
        public LegacyAudienceRepository(IConfiguration config)
        {
            _connection = new SqlConnection(config.GetConnectionString("DemoDB"));
            _connection.Open();
        }

        public async Task<IEnumerable<Audience>> Read()
        {
            var sql = @"SELECT T1.*, T2.Street, T2.City, T2.Province
                        FROM Audiences T1
                        INNER JOIN AudienceAddress T2 ON T2.Audience_Id = T1.Id";            
            var command = new SqlCommand(sql, _connection);
            command.CommandType = CommandType.Text;
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                var returnValue = new List<Audience>();
                while (reader.Read())
                {
                    returnValue.Add(new Audience
                    {
                        Id = reader.GetInt32("Id"),
                        FirstName = reader.GetString("FirstName"),
                        LastName = reader.GetString("LastName"),
                        MiddleName = !reader.IsDBNull("MiddleName") ? reader.GetString("MiddleName") : null,
                        Age = reader.GetInt32("Age"),
                        Address = new Address {
                            Street = !reader.IsDBNull("Street") ? reader.GetString("Street") : null,
                            City = !reader.IsDBNull("City") ? reader.GetString("City") : null,
                            Province = !reader.IsDBNull("Province") ? reader.GetString("Province") : null
                        }
                    });
                }
                return returnValue;
            }
            
            return null;
        }

        #region -- No Implementation --
        public Task<int> Create(Audience audience)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Audience audience)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
