using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmNumberGuessing.Data
{
    public class GameContext : DbContext, IGameContext
    {
        public GameContext(DbContextOptions options) : base(options) { }

        public DbSet<Game> Games { get; set; }
    }
}
