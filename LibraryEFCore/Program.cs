using System;

namespace LibraryEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Автоматическое закрытие объекта
            using (AppContext ap = new AppContext())
            {
                // Создаем Авторов
                Authors author1 = new Authors() { FullName = "Пушкин А.С.", YearOfBirth = 1800 };
                Authors author2 = new Authors() { FullName = "Путин В.В.", YearOfBirth = 1810 };
                Authors author3 = new Authors() { FullName = "Рошель М.Ю.", YearOfBirth = 1719 };
                ap.Authors.AddRange(author1, author2, author3);

                // Создаем Книги
                Books book1 = new Books() { Name = "Как стать программистом гуманитарию", PublicationYear = 1850 };
                Books book2 = new Books() { Name = "Азы С#", PublicationYear = 1860 };
                Books book3 = new Books() { Name = "Руководство EFCore", PublicationYear = 1888 };                
                ap.Books.AddRange(book1, book2);

                // Добавляем Авторам Книги
                author1.Books.Add(book1);
                author1.Books.Add(book2);
                author2.Books.Add(book1);
                author3.Books.Add(book3);

                // Все изменения отправляем в БД
                ap.SaveChanges();
               
                // Выводим на консоль
                foreach (var authors in ap.Authors)
                {
                    Console.WriteLine(authors.FullName);

                    foreach (var books in authors.Books)
                    {
                        Console.WriteLine(books.Name);
                    }
                }
            }
        }
    }
}
