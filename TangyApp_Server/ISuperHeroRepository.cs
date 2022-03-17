using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tangy_DataAccess;

namespace Tangy_Business.Repository.IRepository
{
    public interface ISuperHeroRepository
    {
        public async Task<List<SuperHero>> GetAll();
        public async Task<SuperHero> Get(int id);
        public async Task<List<SuperHero>> Post(SuperHero hero);
        public async Task<List<SuperHero>> Put(SuperHero hero);
        public async Task<List<SuperHero>> Delete(int id);
    }
}
