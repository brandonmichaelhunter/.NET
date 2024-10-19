using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookTrackerWeb.Models;

namespace BookTrackerWEb.Data
{
    public class BookTrackerDBContext : DbContext
    {
        public BookTrackerDBContext (DbContextOptions<BookTrackerDBContext> options)
            : base(options)
        {
        }

        public DbSet<BookTrackerWeb.Models.Book> Book { get; set; }
    }
}
