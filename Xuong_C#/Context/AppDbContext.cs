using Microsoft.EntityFrameworkCore;
using Xuong_C_.Models;

namespace Xuong_C_.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
        {
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Navigation(u => u.Cart)
                .AutoInclude();

            modelBuilder.Entity<Cart>()
                .Navigation(c => c.User)
                .AutoInclude();

            modelBuilder.Entity<Cart>()
                .Navigation(c => c.CartItems)
                .AutoInclude();

            //modelBuilder.Entity<Book>()
            //    .Navigation(b => b.CartItems)
            //    .AutoInclude();

            modelBuilder.Entity<CartItem>()
                .Navigation(ci => ci.Book)
                .AutoInclude();

            modelBuilder.Entity<CartItem>()
                .Navigation(ci => ci.Cart)
                .AutoInclude();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
              new Book { Id = Guid.NewGuid(), Title = "woaa", Author = "Manh",Description="MM",Price=47, Quantity=10,ImagePath = "/images/1984.jpg" },
              new Book { Id = Guid.NewGuid(), Title = "woaa", Author = "Manh", Description = "MM", Price = 40, Quantity = 10, ImagePath = "/images/catcher_in_the_rye.jpg" },
              new Book { Id = Guid.NewGuid(), Title = "woaa", Author = "Manh", Description = "MM", Price = 49, Quantity = 10, ImagePath = "/images/great_gatsby.jpeg" },
              new Book { Id = Guid.NewGuid(), Title = "woaa", Author = "Manh", Description = "MM", Price = 43, Quantity = 10, ImagePath = "/images/moby_dick.jpg" },
              new Book { Id = Guid.NewGuid(), Title = "woaa", Author = "Manh", Description = "MM", Price = 45, Quantity = 10, ImagePath = "/images/to_kill_a_mockingbird.jpg" }
              );
        }
    }
}
