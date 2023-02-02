using Microsoft.EntityFrameworkCore;

namespace AutorApi.Models;

public class AutorContext : DbContext{
    public AutorContext(DbContextOptions<AutorContext> options)
        : base(options){

        }
    public DbSet<Autor> Autores { get; set; } = null!;
}