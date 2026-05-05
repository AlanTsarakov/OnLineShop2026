using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public interface IUserRepository
    {
        void Add(User product);
        void Edit(User product);
        List<User> GetAll();
        User? TryGetById(Guid id);
    }
}