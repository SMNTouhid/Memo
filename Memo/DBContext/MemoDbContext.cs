using Memo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memo.DBContext
{
    public class MemoDbContext : DbContext
    {
        public MemoDbContext(DbContextOptions<MemoDbContext> options) : base()
        {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
    }
}
