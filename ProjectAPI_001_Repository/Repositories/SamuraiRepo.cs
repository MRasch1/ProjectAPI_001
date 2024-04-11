using Microsoft.EntityFrameworkCore;
using ProjectAPI_001_Repository.Context;
using ProjectAPI_001_Repository.Interfaces;
using ProjectAPI_001_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAPI_001_Repository.Repositories
{
    public class SamuraiRepo : ISamuraiRepository
    {
        private readonly DataContext context;
        public SamuraiRepo(DataContext data)
        {
            this.context = data;
        }
        public Samurai Create(Samurai samurai)
        {
            // Context is our Database
            context.Samurai.Add(samurai);
            context.SaveChanges();
            return samurai;
        }

        public List<Samurai> GetAll()
        {
            return context.Samurai.ToList();
        }

        public Samurai GetById(int id) 
        {
            return context.Samurai.FirstOrDefault(s => s.Id == id);
        }

        public Samurai UpdateById(int id, Samurai updatedSamurai)
        {
            var samurai = context.Samurai.FirstOrDefault(s => s.Id == id);

            if (samurai != null)
            {
                samurai.Name = updatedSamurai.Name;
                samurai.Age = updatedSamurai.Age;
                samurai.Description = updatedSamurai.Description;

                context.SaveChanges();
            }

            return samurai;
        }

       public Samurai DeleteById(int id)
       {
            var samurai = context.Samurai.FirstOrDefault(s => s.Id == id);

            if(samurai != null)
            {
                context.Samurai.Remove(samurai);
                context.SaveChanges();
            }
            return samurai;
        }
    }
}
