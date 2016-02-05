using System;
using System.Collections.Generic;
using Timesheet.Domain.Common;

namespace Timesheet.Domain.Entities
{
    public class Task : Entity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Status CurrentStatus { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public float HoursEstimated { get; set; }
        public float HoursRemaining { get; set; }

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        public int EmployeeCreatorId { get; set; }
        public virtual Employee EmployeeCreator { get; set; }

        public virtual ICollection<TimeLog> TimeLogs { get; set; }

        public Task()
        {
            Created = DateTime.UtcNow;
            Updated = Created;
        }

        public enum Status
        {
            New = 0,
            InProgress = 1,
            Paused = 2,
            Cancelled = 3,
            Completed = 4
        }
    }
}
