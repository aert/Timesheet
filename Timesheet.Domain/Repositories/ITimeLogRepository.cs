using System;
using Timesheet.Domain.ValueObjects;

namespace Timesheet.Domain.Repositories
{
    public interface ITimeLogRepository
    {
        TimesheetVO GetTimesheet(int userId, DateTime startDate, DateTime endDate);
    }
}
