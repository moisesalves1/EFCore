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

            var posts = context.Posts.Include(x=>x.Tags);
            foreach (var post in posts)
            {
                foreach (var tag in post.Tags)
                {

                }
            }



        }

    }

}