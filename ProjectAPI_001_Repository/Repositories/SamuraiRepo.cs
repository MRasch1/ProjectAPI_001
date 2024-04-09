using ProjectAPI_001_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAPI_001_Repository.Repositories
{
    public class SamuraiRepo
    {


        public async Task<bool> CreateSamurai(Samurai samurai)
        {
            await _applicationDbContext.Users.AddAsync(user);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
