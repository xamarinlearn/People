﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace People.Models
{
    [Table("people")]
  public  class Person
    {
        // SQLite.NET
        // Propiedad!
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } // ?

        [MaxLength(250), Unique]
        public string Name { get; set; }

        [Unique]
        public int DUI { get; set; }
    }
}
