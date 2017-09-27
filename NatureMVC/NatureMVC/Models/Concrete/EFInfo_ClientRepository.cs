using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NatureMVC.Models.Abstract;
using NatureMVC.Models.Entities;

namespace NatureMVC.Models.Concrete
{
    public class EFInfo_ClientRepository : IInfo_ClientRepository
    {
            private EFDbContext context = new EFDbContext();

            public IEnumerable<Info_Client> Info_Clients
            {
                get { return context.Info_Clients; }
            }
        }
    }
