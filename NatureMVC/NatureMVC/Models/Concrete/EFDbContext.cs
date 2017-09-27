using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NatureMVC.Models.Entities;

namespace NatureMVC.Models.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Info_Client> Info_Clients { get; set; }
        public DbSet<Client_Request> Client_Requests { get; set; }
        public DbSet<Client_Data> Client_Datas { get; set; }
        public DbSet<RangeData> RangeDatas { get; set; }
    }
}