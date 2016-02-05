using System;
using System.Collections.Generic;
using Timesheet.Domain.Common;

namespace Timesheet.Domain.Entities
{
    public class Employee : Entity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDeleted { get; set; }

        public DateTime Arrival { get; set; }
        public DateTime? Departure { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public virtual ICollection<TeamMember> Memberships { get; set; }

        public Employee()
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
