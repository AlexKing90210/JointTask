using Core;

namespace Interfaces
{
    public interface IUsersRewards
    {
        public IEnumerable<User> AddRewards(IEnumerable<User> users, int percent);

    }
}
