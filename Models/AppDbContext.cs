using Microsoft.EntityFrameworkCore;

namespace Practica_2.Models{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<PostModel> Posts { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ToDoModel> ToDos { get; set; }
        public DbSet<AlbumModel> Albums { get; set; }
        public DbSet<PhotoModel> Photos { get; set; }            
  
    }
}