using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NatureMVC.Models.Entity
{
    [MetadataType(typeof(InfoClients))]
    public partial class InfoClient
    {
        public bool check { get; set; }
    }

    public class InfoClients
    {
        [Display(Name = "Phone")]
        [Required]
        public long Phone { get; set; }
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }
        public int Id_C { get; set; }
    }
}