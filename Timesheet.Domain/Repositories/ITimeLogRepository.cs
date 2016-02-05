using System;
using System.Collections.Generic;
using Timesheet.Domain.Common;
using Timesheet.Domain.Entities;

namespace Timesheet.Domain.Repositories
{
    public interface ITimeLogRepository : IRepository
    {
        IList<TimeLog> FindTimeLogs(int empId, DateTime startDate, DateTime endDate);
        void SetTimeLogs(IList<TimeLog> timeLogs, DateTime startDate, DateTime endDate);
    }
}
