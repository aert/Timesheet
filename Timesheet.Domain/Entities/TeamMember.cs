using System;

namespace Timesheet.Domain.Entities
{
    public class TeamMember
    {
        public int Id { get; set; }
        public bool IsTeamLeader { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime? Departure { get; set; }

        public virtual Project Project { get; set; }
        public virtual User User { get; set; }

        #region Properties - Computed

        public bool IsActive { get { return Departure != null; } }

        #endregion
    }
}
