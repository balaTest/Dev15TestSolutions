﻿using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApp_Anc11_core_NoAuth_1.Models
{
    public class BloggingContext : DbContext
        public DbSet<Blog> Blogs { get; set; }
    public class Blog
        public List<Post> Posts { get; set; }
    public class Post
        public int BlogId { get; set; }
}