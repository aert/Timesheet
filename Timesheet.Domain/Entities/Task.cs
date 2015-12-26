using System.Collections.Generic;

namespace Timesheet.Domain.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Status CurrentStatus { get; set; }

        public float EstimatedDuration { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<TimeLog> TimeLogs { get; set; }

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
