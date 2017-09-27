using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace NatureMVC.Models.Entities
{
    public class Client_Request
    {
        public int Id_R { get; set; }
        public int Checkin { get; set; }
        public int Checkout { get; set; }
        public string Request { get; set; }
        public int Adult { get; set; }
        public int Children { get; set; }
    }
}