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
        public DbSet<UserSettings> UsersSettings { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<GPS> GPS { get; set; }

        public DbSet<Alarm> Alarms { get; set; }

        public DbSet<AlarmHistory> AlarmsHistories { get; set; }

        public DbSet<ActivationCondition> ActivationConditions { get; set; }

        private readonly bool isTestingEnviroment;
        public ApplicationContext(DbContextOptions<ApplicationContext> options, bool isTestingEnviroment = false) : base(options)
        {
            this.isTestingEnviroment = isTestingEnviroment;
        }
    }    
}
