using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NatureMVC.Models.Entity;

namespace NatureMVC.Models.Abstract
{
     public interface IClientRepository
    {
        Client Clients { get; set; }
    }
}
