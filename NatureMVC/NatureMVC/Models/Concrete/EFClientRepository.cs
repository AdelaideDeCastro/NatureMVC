using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NatureMVC.Models.Abstract;
using NatureMVC.Models.Entities;

namespace NatureMVC.Models.Concrete
{
    public class EFClientRepository : IClientRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Client> Clients
        {
            get { return context.Clients; }
        }
    }
}