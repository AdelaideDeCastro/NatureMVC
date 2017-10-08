using NatureMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NatureMVC.Models;
using NatureMVC.Models.Concrete;
using NatureMVC.Models.Entity;

namespace NatureMVC.Controllers
{
    public class HomeController : Controller
    {

        private Index repository;

        
        public ActionResult Index()
        {
            EFClientRepository clientRepository = new EFClientRepository();
            clientRepository.Clients = new Client();
            EFInfoClientRepository infoClientRepository = new EFInfoClientRepository();
            infoClientRepository.InfoClients = new InfoClient();
            EFClientRequestRepository clientRequestRepository = new EFClientRequestRepository();
            clientRequestRepository.ClientRequests = new ClientRequest();
            EFDataClientRepository dataClientRepository = new EFDataClientRepository();
            dataClientRepository.DataClients = new DataClient();
            EFRangeDataRepository rangeDataRepository = new EFRangeDataRepository();
            rangeDataRepository.RangeDatas = new RangeData();
            EFClientForeignKeyRepository clientForeignKeyRepository = new EFClientForeignKeyRepository();
            clientForeignKeyRepository.ClientForeignKeys = new ClientForeignKey();

            return View(new Index(clientRepository.Clients, infoClientRepository.InfoClients, clientRequestRepository.ClientRequests, dataClientRepository.DataClients, rangeDataRepository.RangeDatas, clientForeignKeyRepository.ClientForeignKeys));
        }

        [HttpPost]
        public ActionResult Index(Clients clients)   //public ActionResult Index(IndexViewModel indexViewModel)
        {
            EFClientRepository clientRepository = new EFClientRepository();

            return View(); //return View(IndexViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}