using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Context
{

    public class MyContext:DbContext
    {

        static MyContext()
        {

            System.Data.Entity.Database.SetInitializer(
                new System.Data.Entity.CreateDatabaseIfNotExists<MyContext>());

        }
        public MyContext() : base("GenericRepository_DB")

        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
