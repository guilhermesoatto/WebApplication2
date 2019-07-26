using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Models;
using WebApplication.Repository;

namespace WebApplication.Service
{
    public class PlayerService
    {
        private readonly Repository.Repository repository  = new Repository.Repository();

        public string Jogar(string v)
        {
            var g = new Player()
            {
                Name = "Joao",
                Points = 0
            };

            var c = new Computer()
            {
                Name = "PC",
                Points = 0
            };

            return repository.Play(g, c);


        }
    }
}
