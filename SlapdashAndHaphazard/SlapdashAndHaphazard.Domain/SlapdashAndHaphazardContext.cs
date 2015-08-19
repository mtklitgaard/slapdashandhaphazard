﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlapdashAndHaphazard.Domain
{
    public class SlapdashAndHaphazardContext: DbContext
    {
        public SlapdashAndHaphazardContext() : base("SlapdashAndHaphazard")
        {
            
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
