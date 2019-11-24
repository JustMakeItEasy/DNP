using Microsoft.EntityFrameworkCore;
using Example.Data;

namespace Example.DataAccess{
public class CatContext : DbContext{
    public DbSet<Cat> Cats { get; set; }
    
    public CatContext(DbContextOptions<CatContext> ctxOptions) : base(ctxOptions) {
    }
}
}