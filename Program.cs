﻿using System;
using Blog.Data;

namespace Blog 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ctx = new BlogDataContext();
            ctx.Categories;
        }
    }
}