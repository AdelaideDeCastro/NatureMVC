using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NatureMVC.Models.Concrete;
using NatureMVC.Models.Entities;

namespace NatureMVC.Models.ViewModels
{
    public class Index
    {
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Info_Client> Info_Clients { get; set; }
        public IEnumerable<Client_Request> Client_Requests { get; set; }
        public IEnumerable<Client_Data> Client_Datas { get; set; }
        public IEnumerable<RangeData> RangeDatas { get; set; }

        public Index(IEnumerable<Client> Clients, IEnumerable<Info_Client> Info_Clients, IEnumerable<Client_Request> ClientRequests, IEnumerable<Client_Data> Client_Datas, IEnumerable<RangeData> RangeDatas)
        {
            this.Clients = Clients;
            this.Info_Clients = Info_Clients;
            this.Client_Requests = Client_Requests;
            this.Client_Datas = Client_Datas;
            this.RangeDatas = RangeDatas;
        }
    }
}