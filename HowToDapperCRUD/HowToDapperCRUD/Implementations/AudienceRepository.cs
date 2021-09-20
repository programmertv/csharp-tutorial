using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using HowToDapperCRUD.Contracts;
using HowToDapperCRUD.Entities;
using Microsoft.Extensions.Configuration;

namespace HowToDapperCRUD.Implementations
{
    public class AudienceRepository: IAudienceRepository
    {
        private readonly SqlConnection _connection;
        public AudienceRepository(IConfiguration config)
        {
            _connection = new SqlConnection(config.GetConnectionString("DemoDB"));
            _connection.Open();
        }

        public async Task<IEnumerable<Audience>> Read()
        {
            var sql = @"SELECT T1.*, T2.*
                        FROM Audiences T1
                        INNER JOIN AudienceAddress T2 ON T2.Audience_Id = T1.Id";

            //return (await _connection.QueryAsync<Audience>(sql)).ToList();
            return (await _connection.QueryAsync<Audience, Address, Audience>(sql, (audience, address) =>
            {
                audience.Address = address;
                return audience;
            })).ToList();
        }

        public async Task<int> Create(Audience audience)
        {            
            var sql = @"DECLARE @id INT
                    INSERT INTO Audiences([FirstName],[LastName],[Age])
                    VALUES(@FirstName,@LastName,@Age)

                    SET @id = @@IDENTITY

                    INSERT INTO AudienceAddress([Audience_Id],[Street],[City],[Province])
                    VALUES (@id,@Street,@City,@Province)

                    SELECT @id";

            return await _connection.QuerySingleAsync<int>(sql, new
            {
                audience.FirstName,
                audience.LastName,
                audience.Age,
                audience.Address?.Street,
                audience.Address?.City,
                audience.Address?.Province
            });
        }

        public async Task<int> Delete(int id)
        {
            var sql = @"DELETE FROM Audiences WHERE Id = @myId
                        SELECT @@ROWCOUNT";

            return await _connection.QuerySingleAsync<int>(sql, new
            {
                myId = id
            });
        }

        public async Task<int> Update(Audience audience)
        {
            var sql = @"UPDATE Audiences
                    SET
                        FirstName = @FirstName,
                        LastName = @LastName,
                        Age = @Age
                    WHERE Id = @Id
                    SELECT @@ROWCOUNT";

            return await _connection.QuerySingleAsync<int>(sql, audience);
        }
    }
}
