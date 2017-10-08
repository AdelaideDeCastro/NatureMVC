using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureMVC.Models.Abstract
{
    public interface IDataClientRepository
    {
        DataClient DataClients { get; set; }
    }
}
