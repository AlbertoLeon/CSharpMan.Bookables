using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookables.Core.Availability
{
    /// <summary>
    /// Represents the ways to understand availability
    /// </summary>
    public enum AvailabilityTimeBehaviourTypes
    {
        ByHours,
        Daily,
        Weekly,
        Monthly
    }

    /// <summary>
    /// Represents the ways to constrain quotas
    /// </summary>
    public enum AvailabilityQuotaBehaviourTypes
    {
        NoQuota,
        QuotaStrict,
        QuotaExpandable
    }
}
