using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NatureMVC.Models.Entity
{
    [MetadataType(typeof(RangeDatas))]
    public partial class RangeData
    {
        public bool check { get; set; }
    }

    public class RangeDatas
    {
        public int Id_RD { get; set; }
        [Display(Name = "Check availability")]
        [DataType(DataType.Date)]
        [Required]
        public System.DateTime RangeData { get; set; }
        public int Id_D { get; set; }
    }
}