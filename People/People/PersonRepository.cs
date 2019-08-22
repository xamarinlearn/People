using System;
using System.Collections.Generic;
using System.Text;
using People.Models;
using SQLite;

namespace People
{
  public  class PersonRepository
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }

        public PersonRepository(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Person>();
        }

        public void AddNewPerson(string name, int dui)
        {
            int result = 0;
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception("Se requiere un nombre valido");
                }
                result = conn.Insert(new Person { Name = name, DUI = dui });

                StatusMessage = $"{result} records added [Name: {name}";
            }
            catch (Exception ex )
            {

                StatusMessage= $"Failed to add {name}. Error: {ex.Message}";
            }
        }
    }
}
