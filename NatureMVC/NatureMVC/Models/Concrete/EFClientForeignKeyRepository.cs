using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NatureMVC.Models.Abstract;

namespace NatureMVC.Models.Concrete
{
    public class EFClientForeignKeyRepository : IClientForeignKeyRepository
    { 
    //private NatureEntities context = new NatureEntities();

    public ClientForeignKey ClientForeignKeys { get; }

}
}