using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdCategory { get; set; }
        public string Name { get; set; }
        public bool Sate { get; set; }
        public DateTime Created { get; set; }

        public User User { get; set; }
        public Category Category { get; set; }
    }
}
