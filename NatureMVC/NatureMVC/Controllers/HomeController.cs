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
            EFInfoClientRepository infoClientRepository = new EFInfoClientRepository();
            EFClientRequestRepository clientRequestRepository = new EFClientRequestRepository();
            EFDataClientRepository dataClientRepository = new EFDataClientRepository();
            EFRangeDataRepository rangeDataRepository = new EFRangeDataRepository();
            EFClientForeignKeyRepository clientForeignKeyRepository = new EFClientForeignKeyRepository();
            //IndexViewModel indexViewModel = new IndexViewModel();

            return View(new Client());
        }

        [HttpPost]
        public ActionResult Index(Clients client)   //public ActionResult Index(IndexViewModel indexViewModel)
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