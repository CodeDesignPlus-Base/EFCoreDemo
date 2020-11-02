using System;
using System.Collections.Generic;

namespace EFCoreDemo.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int IdRole { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public bool Sate { get; set; }
        public DateTime Created { get; set; }

        public Role Role { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
