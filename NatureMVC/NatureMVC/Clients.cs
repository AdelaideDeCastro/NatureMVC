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
        
        [DisplayName("First Name")]
        [Required]
        public string Firstname { get; set; }
        [DisplayName("Surname")]
        [Required]
        public string Surname { get; set; }
    }
}