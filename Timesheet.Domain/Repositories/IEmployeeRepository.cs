using Timesheet.Domain.Common;
using Timesheet.Domain.Entities;

namespace Timesheet.Domain.Repositories
{
    public interface IEmployeeRepository : IRepository
    {
        bool ValidatePassword(string username, string password);

        Employee FindEmployeeByUsername(string username);

        bool Insert(Employee emp);
        bool Update(Employee emp);
        bool SoftDelete(int empId);
    }
}
