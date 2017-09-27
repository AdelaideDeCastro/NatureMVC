using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NatureMVC.Models.Abstract;
using NatureMVC.Models.Entities;

namespace NatureMVC.Models.Concrete
{
    public class EFClient_RequestRepository : IClient_RequestRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Client_Request> Client_Requests
        {
            get { return context.Client_Requests; }
        }
    }
}