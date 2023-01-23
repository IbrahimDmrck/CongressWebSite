using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class CongressContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySql("server=localhost;port=3306;user=your_database_username;password=your_database_password;database=your_database_name")
                .UseLoggerFactory(LoggerFactory.Create(b => b
                 .AddFilter(level => level >= LogLevel.Information))).EnableSensitiveDataLogging().EnableDetailedErrors();
        }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Announcement> Announcements { get; set; }
        public virtual DbSet<BankAccountInfo> BankAccountInfos { get; set; }
        public virtual DbSet<Congress> Congresses { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<GeneralInformation> GeneralInformations { get; set; }
        public virtual DbSet<Save> Saves { get; set; }
        public virtual DbSet<TransportLayover> TransportLayovers { get; set; }
        public virtual DbSet<TrBankAccountInfo> TrBankAccountInfos { get; set; }
        public virtual DbSet<AdminContactInfo> AdminContactInfos { get; set; }
    }
}
