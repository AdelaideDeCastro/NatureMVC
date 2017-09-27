using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NatureMVC.Models.Entities;

namespace NatureMVC.Models.Abstract
{
    interface IClient_RequestRepository
    {
        IEnumerable<Client_Request> Client_Requests { get; }
    }
}
