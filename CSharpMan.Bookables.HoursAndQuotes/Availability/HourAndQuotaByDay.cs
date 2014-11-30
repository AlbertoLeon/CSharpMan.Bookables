using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookables.Core;
using Itenso.TimePeriod;

namespace CSharpMan.Bookables.HoursAndQuotes.Availability
{
    public class HourAndQuotaByDay : IDayAvailable
    {
        private readonly ITimePeriod _dayAndTime;
        private readonly bool _isBookable;
        private readonly bool _isAvailable;
        private readonly bool _hasQuotas;
        private readonly int _maxQuota;
        private readonly int _freeQuota;
        private readonly int _bookedQuota;

        public HourAndQuotaByDay(ITimePeriod dayAndTime,
            bool isBookable,
            bool isAvailable,
            bool hasQuotas,
            int maxQuota,
            int freeQuota,
            int bookedQuota)
        {
            _dayAndTime = dayAndTime;
            _isBookable = isBookable;
            _isAvailable = isAvailable;
            _hasQuotas = hasQuotas;
            _maxQuota = maxQuota;
            _freeQuota = freeQuota;
            _bookedQuota = bookedQuota;
        }

        public ITimePeriod DayAndTime { get; private set; }
        public bool IsBookable { get; private set; }
        public bool IsAvailable { get; private set; }
        public bool HasQuotas { get; private set; }
        public int MaxQuota { get; private set; }
        public int FreeQuota { get; private set; }
        public int BookedQuota { get; private set; }
    }
}
