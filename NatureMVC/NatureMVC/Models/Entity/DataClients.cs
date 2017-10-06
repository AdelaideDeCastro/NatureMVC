using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NatureMVC.Models.Entity
{
    [MetadataType(typeof(DataClients))]
    public partial class DataClient
    {
        public bool check { get; set; }
    }

    public class DataClients
    {
        public int Id_D { get; set; }
        [Display(Name = "Check availability")]
        [DataType(DataType.Date)]
        [Required]
        public System.DateTime Data { get; set; }
    }
}