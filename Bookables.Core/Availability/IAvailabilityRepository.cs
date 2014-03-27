using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookables.Core
{
    using System.Security.Cryptography.X509Certificates;

    using Itenso.TimePeriod;

    public interface IAvailabilityRepository
    {
        ICollection<ITimePeriod> TimePeriods { get; set; }
    }
}
