using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Tangy_Business.Repository.IRepository;
using Tangy_DataAccess;

namespace Tangy_Business.Repository
{
    public class SuperHeroRepository : ISuperHeroRepository
    {
        public HttpClient _Client;
        public SuperHeroRepository(HttpClient Client)
        {
            _Client = Client;
        }
        public Task<List<SuperHero>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SuperHero> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SuperHero>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<SuperHero>> Post(SuperHero hero)
        {
            throw new NotImplementedException();
        }

        public Task<List<SuperHero>> Put(SuperHero hero)
        {
            throw new NotImplementedException();
        }
    }
}
