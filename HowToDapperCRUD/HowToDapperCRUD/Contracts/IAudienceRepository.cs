using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HowToDapperCRUD.Entities;

namespace HowToDapperCRUD.Contracts
{
    public interface IAudienceRepository
    {
        Task<int> Create(Audience audience);
        Task<IEnumerable<Audience>> Read();
        Task<int> Update(Audience audience);
        Task<int> Delete(int id);
    }
}
