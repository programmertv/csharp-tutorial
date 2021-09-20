using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HowToDapperCRUD.Contracts;
using HowToDapperCRUD.Entities;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HowToDapperCRUD
{
    public class Worker : BackgroundService
    {
        private readonly IAudienceRepository _audienceRepository;

        public Worker(IAudienceRepository audienceRepository)
        {
            _audienceRepository = audienceRepository;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var newId = await _audienceRepository.Create(new Audience
            {
                FirstName = "newName",
                LastName = "newLastName",
                Age = 99,
                Address = new Address {
                    Street = "Far from what you think",
                    City = "Star City",
                    Province = "Nemic"
                }
            });
            await _audienceRepository.Update(new Audience {
                Id = newId,
                FirstName = "editName",
                LastName = "editLastName"
            });
            await _audienceRepository.Delete(1);
            var audiences = await _audienceRepository.Read();
            foreach(var a in audiences)
            {
                Console.WriteLine("**********");
                Console.WriteLine($"Name: {a.FirstName} {a.LastName}");
                Console.WriteLine($"Address: {a.Address?.City}, {a.Address?.Province}");
                Console.WriteLine("**********");
            }
        }
    }
}
