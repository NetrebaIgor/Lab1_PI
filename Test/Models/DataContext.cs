using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Test.Models
{
    public class DataContext : DbContext
    {
       


        public DbSet<InsuranceСar> Cars { get; set; }
        public DbSet<InsuranceMedic> Medic { get; set; }
        public DbSet<InsuranceCOVID> COVID { get; set; }
        public DbSet<InsuranceAutoCitizen> AutoCitizens { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {
            Database.EnsureCreated();   
        }
    }
}
