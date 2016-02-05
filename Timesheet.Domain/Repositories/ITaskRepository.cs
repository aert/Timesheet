using System.Collections.Generic;
using Timesheet.Domain.Common;
using Timesheet.Domain.Entities;

namespace Timesheet.Domain.Repositories
{
    public interface ITaskRepository : IRepository
    {
        IList<Task> FindByProject(int projectId);
        IList<Task> FindByProjectAndStatus(int projectId, Task.Status status);

        void Insert(Task task);
        void Update(Task task);
        void Delete(int taskId);
    }
}
