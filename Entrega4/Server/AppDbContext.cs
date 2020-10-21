
using Microsoft.EntityFrameworkCore;

using Entrega4.Shared;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
      : base(options)
    {
    }
    public DbSet<Produto> Produtos { get; set; }
}