using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookables.Core
{
    using System.Security.Cryptography.X509Certificates;

    using Itenso.TimePeriod;

    public interface IAvailabilityReadRepository
    {
        IEnumerable<IDayAvailable> GetDais(ITimePeriod timePeriod);
    }

    public interface IDayAvailable
    {
        bool IsBookable { get; }
        bool IsAvailable { get; }
    }

    public interface IAvailabilityWriteRepository
    {
        
    }
}
