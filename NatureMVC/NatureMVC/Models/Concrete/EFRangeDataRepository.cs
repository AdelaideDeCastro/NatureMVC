using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NatureMVC.Models.Abstract;
using NatureMVC.Models.Entities;

namespace NatureMVC.Models.Concrete
{
    interface EFRangeDataRepository : IRangeDataRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<RangeData> RangeDatas
        {
            get { return context.RangeDatas; }
        }
    }
}
 
