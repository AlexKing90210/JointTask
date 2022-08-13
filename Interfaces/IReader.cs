using Core;

namespace Interfaces
{
    public interface IReader
    {
        public IEnumerable<User> Read(string path);

    }
}
