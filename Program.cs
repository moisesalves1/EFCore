using System;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            // context.Users.Add(new User{
            //    Bio = "9X microsoft MVP",
            //    Email = "andre@balta.io",
            //    Image = "https://balta.io",
            //    Name = "Andre Baltiei",
            //    PasswordHash = "1234",
            //    Slug = "andre-baltieri"
            // });

            var user = context.Users.FirstOrDefault();
            var post = new Post{
               Author = user,
               Body = "Meu artigo",
               Category = new Category
               {
                    Name = "Backend",
                    Slug = "backend"
               },
               CreateDate = System.DateTime.Now,
               Slug = "meu-artigo",
               Summary = "Neste artigo vamos conferir...",
               Title = "Meu artigo"
            };

            context.Posts.Add(post);
            
            context.SaveChanges();

        }
    }
}