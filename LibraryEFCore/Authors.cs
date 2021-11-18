using System;
using System.Collections.Generic;
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
}
