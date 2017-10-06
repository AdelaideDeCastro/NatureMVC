using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NatureMVC.Models.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;



namespace NatureMVC.Models.ViewModels
{
    [MetadataType(typeof(IndexViewModel))]
    public class Index
    {
        [HiddenInput(DisplayValue = false)]
        public IClientRepository Clients { get; set; }
        public IInfoClientRepository InfoClients { get; set; }
        public IClientRequestRepository ClientRequests { get; set; }
        public IDataClientRepository DataClients { get; set; }
        public IRangeDataRepository RangeDatas { get; set; }
        public IClientForeignKeyRepository ClientForeignKeys { get; set; }

        public Index(IClientRepository Clients, IInfoClientRepository InfoClients, IClientRequestRepository ClientRequests, IDataClientRepository DataClients, IRangeDataRepository RangeDatas, IClientForeignKeyRepository ClientForeignKeys)
        {
            this.Clients = Clients;
            this.InfoClients = InfoClients;
            this.ClientRequests = ClientRequests;
            this.DataClients = DataClients;
            this.RangeDatas = RangeDatas;
            this.ClientForeignKeys = ClientForeignKeys;
        }
    }
}

