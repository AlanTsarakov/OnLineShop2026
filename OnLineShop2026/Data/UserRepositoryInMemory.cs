using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class UserRepositoryInMemory : IUserRepository
    {
        private static List<User> users = new List<User>()
        {
            new User("Алан", "Цараков", "alantsarakov@vk.com", "https://avatars.mds.yandex.net/i?id=7acb83785e60f3df8da676c2b2227b5d_l-5237670-images-thumbs&n=13"),
            new User("Давид", "Плиев", "pliev@vk.com", "https://avatars.mds.yandex.net/i?id=7acb83785e60f3df8da676c2b2227b5d_l-5237670-images-thumbs&n=13"),
            new User("Гоша", "Гузитаев", "guzitaev@vk.com", "https://avatars.mds.yandex.net/i?id=7acb83785e60f3df8da676c2b2227b5d_l-5237670-images-thumbs&n=13")
        };

        public List<User> GetAll()
        {
            return users;
        }

        public User? TryGetById(Guid id)
        {
            return users.FirstOrDefault(product => product.Id == id);
        }

        public void Add(User product)
        {
            users.Add(product);
        }

        public void Edit(User product)
        {
            User editProduct = TryGetById(product.Id);
            editProduct.Name = product.Name;
        }
    }
}
