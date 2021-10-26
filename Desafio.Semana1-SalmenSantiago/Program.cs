using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Desafio.Semana1_SalmenSantiago.Context;
using Desafio.Semana1_SalmenSantiago.Entities;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Semana1_SalmenSantiago
{
    class Program
    {
        static void Main(string[] args)
        {
            


           
            using (var ctx = new UserContext())
            {
                var Comment = new Comment()
                {
                    id = 1,
                    Date = 2020,
                    Content = "Hello Word"
                };

                ctx.Comments.Add(Comment);
                ctx.SaveChanges();
            }
        }

    }
}


