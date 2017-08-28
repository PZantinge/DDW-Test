using System;
using System.ComponentModel.DataAnnotations;

namespace FarmNumberGuessing.Data
{
    public class Game
    {
        public Game()
        {
            Started = DateTimeOffset.Now;
        }

        [Key]
        public Guid Id { get; set; }
        public DateTimeOffset Started { get; private set; }
        [Range(4,8)]
        public int Digits { get; set; }
        public int Number { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Player")]
        public Guid PlayerId { get; set; }
        public virtual Player Player { get; set; }
    }
}
