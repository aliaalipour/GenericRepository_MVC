using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;
using DataLayer.Services;

namespace Client_App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
                //Person p=new Person()
                //{
                //   Name = "ali",
                //    Family = "aliaalipour",
                //    WebSite = "mstop.ir"
                //};
                //db.Persons.Add(p);
                //db.SaveChanges();

                //IPersonRepository personRepository = new PersonRepository(db);
                //personRepository.InsertPerson(new Person()
                //{
                //    Name = "mohamad",
                //    Family = "omidi",
                //    WebSite = "takhfifgozar.ir"
                //});
                //personRepository.Save();


                MyGenericRepository<Person> personRepository = new MyGenericRepository<Person>(db);

                var query = personRepository.Get(p => p.Name == "mohamad").FirstOrDefault();


                if (query != null)
                {
                    Console.WriteLine(query.Name + " " + query.Family);
                }
                else
                {
                    Console.WriteLine("Person Not Found!!");
                }
                Console.ReadLine();
            }
        }
    }
}
