using Core.Utilities.Security.JWT;
using Entities;
using Entities.PostgreSql.EntitiesPostgre;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Postgre.Concrete
{
    public class PostgreDbContext: DbContext
    {
        public IConfiguration Configuration { get; }
        private ConnectionString _connectionS;

        


       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //_connectionS = Configuration.GetSection("ConnectionString").Get<ConnectionString>();

            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();   
               
            
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("ConnectionS"));
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolLesson> SchoolLessons { get; set; }




        //  entity classının ılk harflarını buyutup asagıdakı metodu her özellık için yenıden set edıp calıstıracaz


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<City>().Property("Id").HasColumnName("id");
        //}
    }






}
