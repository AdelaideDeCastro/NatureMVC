using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NatureMVC.Models.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using NatureMVC.Models.Concrete;

namespace NatureMVC.Models.ViewModels
{
    [MetadataType(typeof(IndexViewModel))]
    public class Index
    {
        public Client Clients { get; set; }
        public InfoClient InfoClients { get; set; }
        public ClientRequest ClientRequests { get; set; }
        public DataClient DataClients { get; set; }
        public RangeData RangeDatas { get; set; }
        public ClientForeignKey ClientForeignKeys { get; set; }

        public Index(Client Clients, InfoClient InfoClients, ClientRequest ClientRequests, DataClient DataClients, 
           RangeData RangeDatas, ClientForeignKey ClientForeignKeys)
        {
            this.Clients=Clients;
            this.InfoClients=InfoClients;
            this.ClientRequests=ClientRequests;
            this.DataClients=DataClients;
            this.RangeDatas=RangeDatas;
            this.ClientForeignKeys=ClientForeignKeys;
        }
    }
}

