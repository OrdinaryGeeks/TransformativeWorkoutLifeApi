using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFWAPIFixed.Models;

namespace TFWAPIFixed.Models
{
    public class DBContext : DbContext
    {


        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }


        public DbSet<TFWAPIFixed.Models.Admin> Admin { get; set; }


        public DbSet<TFWAPIFixed.Models.Bio> Bio { get; set; }



        public DbSet<TFWAPIFixed.Models.Blog> Blog { get; set; }



        public DbSet<TFWAPIFixed.Models.Blurb> Blurb { get; set; }


        public DbSet<TFWAPIFixed.Models.Item> Item { get; set; }


        public DbSet<TFWAPIFixed.Models.Merchant> Merchant { get; set; }


        public DbSet<TFWAPIFixed.Models.Product> Product { get; set; }


        public DbSet<TFWAPIFixed.Models.Trainer> Trainer { get; set; }


        public DbSet<TFWAPIFixed.Models.Training> Training { get; set; }


        public DbSet<TFWAPIFixed.Models.TrainingVideo> TrainingVideo { get; set; }


        public DbSet<TFWAPIFixed.Models.Guest> Guest { get; set; }


        public DbSet<TFWAPIFixed.Models.GuestItemOrdered> GuestItemOrdered { get; set; }


        public DbSet<TFWAPIFixed.Models.GuestOrder> GuestOrder { get; set; }


        public DbSet<TFWAPIFixed.Models.GuestSchedule> GuestSchedule { get; set; }


        public DbSet<TFWAPIFixed.Models.GuestTrainingOrdered> GuestTrainingOrdered { get; set; }


        public DbSet<TFWAPIFixed.Models.Schedule> Schedule { get; set; }



    }
}
