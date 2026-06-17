using EcommerceMonolith.Models;
using EcommerceMonolith.Repositories;

namespace EcommerceMonolith.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<User> GetAll()
        {
            return _repo.GetAll();
        }

        public User GetById(int id)
        {
            var user = _repo.GetById(id);

            if (user == null)
                throw new Exception("User not found");

            return user;
        }

        public User Register(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Name))
                throw new Exception("Name required");

            if (string.IsNullOrWhiteSpace(user.Email))
                throw new Exception("Email required");

            return _repo.Create(user);
        }
    }
}
