using Microsoft.EntityFrameworkCore;
using webapi.Model;

namespace webapi.Data
{
    public class Datacontext:DbContext
    {
        public Datacontext(DbContextOptions<Datacontext> options):base (options){}
        public DbSet<Value> Value { get; set; }
    }
}