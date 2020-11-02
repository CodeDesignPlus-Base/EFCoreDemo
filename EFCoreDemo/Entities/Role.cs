using System;
using System.Collections.Generic;

namespace EFCoreDemo.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Sate { get; set; }
        public DateTime Created { get; set; }

        public List<User> Users { get; set; } = new List<User>();
    }
}
