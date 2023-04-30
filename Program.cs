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
            using (var context = new BlogDataContext())
            {
                // var tag = new Tag {Name = ".NET Core", Slug="netcore"};
                // context.Tags.Add(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x=>x.Id == 2);
                // tag.Name = ".NET";
                // tag.Slug = "dotnet";

                // context.Update(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x=>x.Id == 2);

                // context.Remove(tag);
                // context.SaveChanges();

                // var tags = context
                //     .Tags
                //     .ToList();

                // foreach( var tag in tags){
                //     Console.WriteLine(tag.Name);
                // }

                // var tags = context
                //     .Tags
                //     .AsNoTracking()
                //     .ToList();

                //     foreach (var tag in tags){
                //         Console.WriteLine(tag.Name);
                //     }

                // var tag = context
                //     .Tags
                //     .AsNoTracking() //Remover
                //     .FirstOrDefault(x=>x.Id == 1002);
                // tag.Name = ".NET";
                // tag.Slug = "dotnet";

                // context.Update(tag);
                // context.SaveChanges();
            }



        }
    }
}