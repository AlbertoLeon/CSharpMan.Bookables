using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookables.Core
{
    using Itenso.TimePeriod;

    /// <summary>
    /// An object responsible to check if IBookableItem is available
    /// </summary>
    public interface IAvailabilityChecker
    {
        /// <summary>
        /// Aks for the availability of a searched timeperiod in a item
        /// </summary>
        /// <param name="bookableItem">An item with periods</param>
        /// <param name="timePeriod">A time period to check if is available</param>
        /// <returns>Returns true if the period is available</returns>
        bool IsAvailable(IBookableItem bookableItem, ITimePeriod timePeriod);
    }
}
