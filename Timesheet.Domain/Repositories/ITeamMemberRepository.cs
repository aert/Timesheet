using System.Collections.Generic;
using Timesheet.Domain.Common;
using Timesheet.Domain.Entities;

namespace Timesheet.Domain.Repositories
{
    public interface ITeamMemberRepository : IRepository
    {
        IList<TeamMember> FindByProject(int projectId);

        void Insert(TeamMember member);
        void Update(TeamMember member);
    }
}
