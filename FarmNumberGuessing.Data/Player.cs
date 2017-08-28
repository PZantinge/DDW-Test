using System;
using System.Collections.Generic;
using System.Text;

namespace FarmNumberGuessing.Data
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
