using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tangy_DataAccess;

namespace TangyApp_Server.Services
{
    public interface ISuperHeroRepository
    {
        public Task<List<SuperHero>> GetAll();
        public Task<SuperHero> Get(int id);
        public Task<HttpResponseMessage> Post(SuperHero hero);
        public Task<HttpResponseMessage> Put(SuperHero hero);
        public Task<HttpResponseMessage> Delete(int id);
    }
}
