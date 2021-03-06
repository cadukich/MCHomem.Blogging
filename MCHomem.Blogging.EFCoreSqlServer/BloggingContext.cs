﻿using MCHomem.Blogging.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace MCHomem.Blogging.EFCoreSqlServer
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=localhost\SQL2017;Database=EFCoreBlogging;User Id=sa;Password=sa@2012;");
    }
}
