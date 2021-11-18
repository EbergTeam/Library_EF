using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFCore
{
    // класс-модель Книги
    public class Books
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PublicationYear { get; set; }
        public List<Authors> Authors { get; set; } = new List<Authors>(); // Связь Many-to-many 
    }
}
