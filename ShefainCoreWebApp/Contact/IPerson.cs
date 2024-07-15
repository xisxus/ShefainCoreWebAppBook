using ShefainCoreWebApp.Core.Entities;

namespace ShefainCoreWebApp.Contact
{
    public interface IPerson
    {
        public Task<int> AddPerson(Person person);
    }
}
