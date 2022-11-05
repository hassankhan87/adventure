using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IAdventureRepository
    {
        Task<Adventure?> GetByIdAsync(Guid adventureId);
        void Insert(Adventure adventure);
    }
}
