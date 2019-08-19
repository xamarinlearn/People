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

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
