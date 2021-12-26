using Microsoft.EntityFrameworkCore;
using RegistrationWebApi.Model.SP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RegistrationWebApi.Model
{
    public class RegistrationContext:DbContext
    {
        public RegistrationContext(DbContextOptions<RegistrationContext> options)
           : base(options)
        {
        }
        public DbSet<Regisdata> Regisdata { get; set; }
    }
}
