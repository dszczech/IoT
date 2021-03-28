using Microsoft.EntityFrameworkCore;
using PeopleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleApp
{
    public class PeopleDb : DbContext
    {
        public PeopleDb(DbContextOptions<PeopleDb> options) 
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
