using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BullsAndCows.Data.Repository;
using BullsAndCows.Models;

namespace BullsAndCows.Data
{
    public interface IBullsAndCowsData
    {
        IRepository<ApplicationUser> Users { get; }

        IRepository<Game> Games { get; }

        int SaveChanges();
    }
}