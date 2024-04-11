using ProjectAPI_001_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAPI_001_Repository.Interfaces
{
    public interface ISamuraiRepository
    {
        Samurai Create(Samurai samurai);
        List<Samurai> GetAll();
        Samurai GetById(int id);
        Samurai UpdateById(int id, Samurai updatedSamurai);
    }
}
