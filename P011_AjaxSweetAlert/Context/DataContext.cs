using Microsoft.EntityFrameworkCore;
using P011_AjaxSweetAlert.Models;

namespace P011_AjaxSweetAlert.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Sektor> Sektorler { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}
