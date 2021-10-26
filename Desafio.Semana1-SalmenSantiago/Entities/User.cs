using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Semana1_SalmenSantiago.Entities
{
    class User
    {

        public int id { get; set; }

        public string Name { get; set; }

        public string  Password { get; set; }

        public string Email { get; set; }
       
        public ICollection<Post> Posts { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
