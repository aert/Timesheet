using System;
using System.Collections.Generic;
using Timesheet.Domain.Common;

namespace Timesheet.Domain.Entities
{
    public class Project : Entity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public int EmployeeCreatorId { get; set; }
        public virtual Employee EmployeeCreator { get; set; }

        public virtual ICollection<TeamMember> TeamMembers { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

        public Project()
        {
            Created = DateTime.UtcNow;
            Updated = Created;
        }
    }
}
