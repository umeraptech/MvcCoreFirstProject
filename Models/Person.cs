using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreFirstProject.Models
{
    public class Person
    {
        
        public int ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
    }

    public class PersonContext : DbContext {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options) {
            
        }
        public DbSet<Person> people { get; set; }
    }
       
}
