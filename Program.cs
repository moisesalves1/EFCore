using System;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    internal class NewBaseType
    {
        static async Task Main(string[] args)
        {
            using var context = new BlogDataContext();

            var post = await context.Posts.ToListAsync();
            var tags = await context.Users.ToListAsync();

            var posts = await GetPosts(context);

            Console.WriteLine("teste");
        }

        public static async Task<IEnumerable<Post>> GetPosts(BlogDataContext context)
        {
            return await context.Posts.ToListAsync();
        }
    }

}