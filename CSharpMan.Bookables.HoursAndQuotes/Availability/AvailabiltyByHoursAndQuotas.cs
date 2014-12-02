using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookables.Core;
using Itenso.TimePeriod;

namespace CSharpMan.Bookables.HoursAndQuotes.Availability
{
    public class AvailabiltyByHoursAndQuotas : IAvailabilityReadRepository
    {
        public IEnumerable<IDayAvailable> GetDais(ITimePeriod timePeriod)
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<HourAndQuotaByDay> 
    }
}
