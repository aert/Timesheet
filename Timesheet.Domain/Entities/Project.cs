using System.Collections.Generic;

namespace Timesheet.Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TeamMember> TeamMembers { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
