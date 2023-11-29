using Microsoft.EntityFrameworkCore;
using BookAPI.Models;

namespace BookAPI.Data
{
    public class ApplicattionDbContext : DbContext
    {
        public ApplicattionDbContext(DbContextOptions<ApplicattionDbContext> options) : base(options)
        {
        }


        public DbSet<EmprestimosModel> Emprestimos { get; set; }
    }

}
