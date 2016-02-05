using System;
using System.Collections.Generic;
using Timesheet.Domain.Common;

namespace Timesheet.Domain.Entities
{
    public class TeamMember : Entity
    {
        public int Id { get; set; }
        public bool IsProjectAdmin { get; set; }

        public DateTime Arrival { get; set; }
        public DateTime? Departure { get; set; }

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public virtual ICollection<Task> AssignedTasks { get; set; }
        public virtual ICollection<TimeLog> TimeLogs { get; set; }

        public TeamMember()
        {
            Arrival = DateTime.UtcNow;
            Created = Arrival;
            Updated = Created;
        }

        #region Properties - Computed

        public bool IsActive => Departure != null;

        #endregion
    }
}
