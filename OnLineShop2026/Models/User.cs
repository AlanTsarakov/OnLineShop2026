using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineShop2026.Models
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
        }

        public User(string? name, string? surname, string? email, string? urlAvatar) : this()
        {
            Name = name;
            Surname = surname;
            Email = email;
            UrlAvatar = urlAvatar;
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? UrlAvatar { get; set; }
    }
}
