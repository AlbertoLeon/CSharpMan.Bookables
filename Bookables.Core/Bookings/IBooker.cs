using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookables.Core
{
    using Itenso.TimePeriod;

    /// <summary>
    /// Reponsible to reduce availability / to book a time range or time period
    /// </summary>
    public interface IBooker
    {
        /// <summary>
        /// Books the time period provided
        /// </summary>
        /// <param name="bookableItem">An item with time periods</param>
        /// <param name="timePeriod">A time block, time period or time range to be booked</param>
        void Book(IBookableItem bookableItem, ITimePeriod timePeriod);
    }
}
