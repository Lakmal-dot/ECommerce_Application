using Ecommerce.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.OrderService.Data
{
    public class OrderDbcontext: DbContext
    {
        public OrderDbcontext(DbContextOptions<OrderDbcontext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<OrderModel> Orders { get; set; }
    }
}
