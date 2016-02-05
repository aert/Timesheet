using System.Collections.Generic;
using Timesheet.Domain.Common;
using Timesheet.Domain.Entities;

namespace Timesheet.Domain.Repositories
{
    public interface IProjectRepository : IRepository
    {
        IList<Project> FindAll();
        IList<Project> Find(int empId);

        void Insert(Project project);
        void Update(Project project);
        void SoftDelete(int projectId);
    }
}
