using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Semana1_SalmenSantiago.Entities
{
    class Comment
    {
        public int id { get; set; }

        public int Date { get; set; }

        public string Content { get; set; }

        public User User { get; set; }
    }
}
