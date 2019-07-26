using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Interface
{
    public interface IPlayers
    {
        string Name { get; set; }
        int Points { get; set; }
    }
}
