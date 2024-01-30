using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorAppSacfolding;

namespace BlazorAppSacfolding.Data
{
    public class BlazorAppSacfoldingContext : DbContext
    {
        public BlazorAppSacfoldingContext (DbContextOptions<BlazorAppSacfoldingContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorAppSacfolding.Blog> Blog { get; set; } = default!;
    }
}
