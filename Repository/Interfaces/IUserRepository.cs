using ComplaintRequestSystem.Entities;
using System.Linq.Expressions;

namespace ComplaintRequestSystem.Repository.Interfaces
{
    public interface IUserRepository : IUserRepository<User>
    {
        User GetUser(Expression<Func<User, bool>> expression);
    }
}
