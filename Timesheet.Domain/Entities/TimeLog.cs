using System;
using Timesheet.Domain.Common;

namespace Timesheet.Domain.Entities
{
    public class TimeLog : Entity
    {
        public int Id { get; set; }
        public DateTime SampleDate { get; set; }
        public float HoursSpent { get; set; }
        public float HoursRemaining { get; set; }
        public float HoursRemainingBeforeUpdate { get; set; }

        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public int TeamMemberId { get; set; }
        public virtual TeamMember TeamMember { get; set; }

        public DateTime Updated { get; set; }

        public TimeLog()
        {
            Updated = DateTime.UtcNow;
        }
    }
}
