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
            // Lazy loading
            // Eager Loading
            using var context = new BlogDataContext();

            var posts = context.PostWithTagsCount.ToList();
            foreach(var item in posts){
            }

            Console.WriteLine("teste");

        }

        public static List<Post> GetPosts(BlogDataContext context, int skip = 0, int take = 25){
            var posts = context
                .Posts
                .AsNoTracking()
                .Skip(skip)
                .Take(take)
                .ToList();

            return posts;
        }

    }

}