﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Interface;

namespace WebApplication.Data.Models
{
    public class Computer : IPlayers
    {
        public string Name { get; set ; }
        public int Points { get; set ; }
    }
}
