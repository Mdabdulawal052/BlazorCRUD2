using BlazorCRUD2.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD2.DataAccess
{
    public class AppContext : DbContext
    {
        public AppContext() { }

        public AppContext(DbContextOptions<AppContext> options) : base(options) { }

        DbSet<Article> Article { get; set; }
    }
}
