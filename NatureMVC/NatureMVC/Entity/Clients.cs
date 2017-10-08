using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace NatureMVC
{
    
    public partial class Clients
    {

        [Required]
        [DisplayName("First Name")]
        public string  Name { get; set; }
        [Required]
        [DisplayName("Surname")]
        public string Surname { get; set; }
    }
}