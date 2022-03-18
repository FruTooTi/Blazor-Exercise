﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Tangy_DataAccess;

namespace TangyApp_Server.Services
{
    public class SuperHeroRepository : ISuperHeroRepository
    {
        public HttpClient _Client;
        public SuperHeroRepository(HttpClient Client)
        {
            _Client = Client;
        }
        public async Task<HttpResponseMessage> Delete(int id)
        {
            return await _Client.DeleteAsync($"api/superhero/{id}");
        }

        public async Task<SuperHero> Get(int id)
        {
            return await _Client.GetFromJsonAsync<SuperHero>($"api/superhero/{id}");
        }

        public async Task<List<SuperHero>> GetAll()
        {
            return await _Client.GetFromJsonAsync<List<SuperHero>>("api/superhero");
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
