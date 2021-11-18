using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFCore
{
    // класс-модель Авторы
    public class Authors
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int YearOfBirth { get; set; }
        public List<Books> Books { get; set; } = new List<Books>(); // Связь Many-to-many 
    }
    // класс-модель Книги
    public class Books
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PublicationYear { get; set; }
        public List<Authors> Authors { get; set; } = new List<Authors>(); // Связь Many-to-many 
    }

    public class AppContext: DbContext
    {
        // Объявляем наборы объектов, через которые идет связь с соответствующей по имени таблицей в БД
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Books> Books { get; set; }

        // Конструктор, где пересоздаем БД
        public AppContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }       

        // Переопределяем метод для передачи строки подключения
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=libraryDB;Trusted_Connection=True;");
        }
    }
}
