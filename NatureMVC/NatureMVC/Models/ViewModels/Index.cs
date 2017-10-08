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
        public EFClientRepository Clients { get; set; }
        public EFInfoClientRepository InfoClients { get; set; }
        public EFClientRequestRepository ClientRequests { get; set; }
        public  EFDataClientRepository DataClients { get; set; }
        public  EFRangeDataRepository RangeDatas { get; set; }
        public  EFClientForeignKeyRepository ClientForeignKeys { get; set; }

        public Index(IClientRepository Clients, EFInfoClientRepository InfoClients, EFClientRequestRepository ClientRequests, EFDataClientRepository DataClients, 
            EFRangeDataRepository RangeDatas, EFClientForeignKeyRepository ClientForeignKeys)
        {
            this.Clients.Clients = Clients.Clients;
            this.InfoClients.InfoClients = InfoClients.InfoClients;
            this.ClientRequests.ClientRequests = ClientRequests.ClientRequests;
            this.DataClients.DataClients = DataClients.DataClients;
            this.RangeDatas.RangeDatas = RangeDatas.RangeDatas;
            this.ClientForeignKeys.ClientForeignKeys = ClientForeignKeys.ClientForeignKeys;
        }
    }
}

