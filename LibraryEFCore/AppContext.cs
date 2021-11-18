using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFCore
{
    public class AppContext: DbContext
    {
        // Объявляем наборы объектов, через которые идет связь с соответствующей по имени таблицей в БД
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Books> Books { get; set; }

        // Конструктор, где пересоздаем БД. При миграции не используем 
        public AppContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }       

        // Переопределяем метод для передачи строки подключения
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=libraryDB;Trusted_Connection=True;");
        }
    }
}
