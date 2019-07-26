using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Models;

namespace WebApplication.Repository
{
    public class Repository
    {
        private readonly Context.Context _context;

        public string Play(Player player, Computer computer)
        {
            int jogadapc = new Random().Next(0,2);
            int jogadaplayer = 0;
           
            if(jogadapc == jogadaplayer)
            {
                return "";
            }
            _context.Add(player);
            _context.SaveChanges();
            switch (jogadaplayer)
            {
                case 0:
                    return jogadapc == 1 ? "PC" : "Jogador" ;
                case 1:
                    return jogadapc == 2 ? "PC" : "Jogador";
                default:
                    return jogadapc == 0 ? "PC" : "Jogador"; ;
            }
        }
    }
}
