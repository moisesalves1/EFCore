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

            var posts = GetPosts(context, 0, 25);
            var posts2 = GetPosts(context, 25, 25);
            var posts3 = GetPosts(context, 50, 25);
            var posts4 = GetPosts(context, 75, 25);

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