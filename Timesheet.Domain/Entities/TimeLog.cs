using System;

namespace Timesheet.Domain.Entities
{
    public class TimeLog
    {
        public int Id { get; set; }
        public virtual TeamMember TeamMember { get; set; }
        public virtual Task Task { get; set; }

        public DateTime Day { get; set; }

        public float TimeSpent { get; set; }
        public float TimeRemaining { get; set; }

        public DateTime Updated { get; set; }
    }
}
