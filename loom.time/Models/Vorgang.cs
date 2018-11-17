using System;
using SQLite;

namespace loom.time.Models
{
    public class Vorgang
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        [MaxLength(8)]
        public string Symbol { get; set; }

        public string Name { get; set; }
    }
}


