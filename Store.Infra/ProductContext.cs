using Microsoft.EntityFrameworkCore;
using Store.DTOs;

namespace Store.Infra;

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions<ProductContext> options)
        : base(options)
    {
    }

    public DbSet<ProductDto> Products { get; set; } = null!;

}

