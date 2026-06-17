using EcommerceMonolith.Models;

namespace EcommerceMonolith.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Register(User user);
    }
}
