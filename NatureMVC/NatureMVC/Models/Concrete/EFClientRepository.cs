using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NatureMVC.Models.Abstract;
using NatureMVC.Models.Entity;


namespace NatureMVC.Models.Concrete
{
    public class EFClientRepository : IClientRepository
    {
        /*private NatureEntities context = new NatureEntities();*/

        public Client Clients { get; set; }
    }
}