using System.Collections.Generic;
using Timesheet.Domain.Entities;

namespace Timesheet.Domain.ValueObjects
{
    public class TimesheetVO
    {
        public ICollection<TimeLog> TimeLogs { get; set; }
    }
}
