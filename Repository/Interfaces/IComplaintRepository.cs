using ComplaintRequestSystem.Entities;
using System.Linq.Expressions;

namespace ComplaintRequestSystem.Repository.Interfaces
{
    public interface IComplaintRepository : IUserRepository<Complaint>
    {
        List<Complaint> GetComplaints();
        List<Complaint> GetComplaints(Expression<Func<Complaint, bool>> expression);
        Complaint GetComplaint(Expression<Func<Complaint, bool>> expression);
        List<Department> GetComplaintByDepartmentId(string id);
        List<Department> SelectComplaintByDepartment();
    }
}
