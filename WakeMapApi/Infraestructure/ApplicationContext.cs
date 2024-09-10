using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        private readonly bool isTestingEnviroment;
        public ApplicationContext(DbContextOptions<ApplicationContext> options, bool isTestingEnviroment = false) : base(options)
        {
            this.isTestingEnviroment = isTestingEnviroment;
        }
    }    
}
