using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NatureMVC.Models.Entity
{
    [MetadataType(typeof(ClientForeignKeys))]
        public partial class ClientForeignKey
    {
        public bool check { get; set; }
    }
    public class ClientForeignKeys
    { 
            public int Id_FK { get; set; }
            public int Id_C { get; set; }
            public int Id_RD { get; set; }
        }
}