using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace NatureMVC.Models.Entity
{
    [MetadataType(typeof(ClientRequests))]
    public partial class ClientRequest
    {
        public bool check { get; set; }
    }

    public class ClientRequests
    {
        public int Id_R { get; set; }
        [Display(Name = "Checkin")]
        [DataType(DataType.Date)]
        [Required]
        public System.DateTime Checkin { get; set; }
        [Display(Name = "Check-out")]
        [DataType(DataType.Date)]
        [Required]
        public System.DateTime Checkout { get; set; }
        [Display(Name = "Requests")]
        [Required]
        public string Request { get; set; }
        [Display(Name = "Adults")]
        [Required]
        public int Adult { get; set; }
        [Display(Name = "Children")]
        [Required]
        public Nullable<int> Children { get; set; }
        public int Id_C { get; set; }
    }
}