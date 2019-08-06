using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingAppREST.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingAppREST.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<Value> Values { get; set; }
    }
}
