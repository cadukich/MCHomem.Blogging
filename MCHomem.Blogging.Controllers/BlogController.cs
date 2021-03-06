﻿using MCHomem.Blogging.EFCoreSqlServer.Repository;
using MCHomem.Blogging.Models.Entity;
using System.Collections.Generic;

namespace MCHomem.Blogging.Controllers
{
    public class BlogController
    {
        public void Add(Blog blog)
        {
            new BlogRepository().Create(blog);
        }

        public void Refresh(Blog blog)
        {
            new BlogRepository().Update(blog);
        }

        public void Remove(Blog blog)
        {
            new BlogRepository().Delete(blog);
        }

        public Blog Get(Blog blog)
        {
            return new BlogRepository().Details(blog);
        }

        public List<Blog> GetAll(Blog blog = null)
        {
            return new BlogRepository().Retreave(blog);
        }
    }
}
