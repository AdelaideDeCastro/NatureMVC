using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NatureMVC.Models.Entities;

namespace NatureMVC.Models.Abstract
{
    interface IInfo_ClientRepository
    {
        IEnumerable<Info_Client> Info_Clients { get; }
    }
}
