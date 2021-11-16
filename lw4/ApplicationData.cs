using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lw4
{
    public class ApplicationData
    {
        private List<Reader> readers = new List<Reader>();
        private List<Book> books = new List<Book>();

        public List<Reader> Readers { get { return readers; } }
        public List<Book> Books { get { return books; } }

        public override string ToString()
        {
            return $"<{Readers}>, <{Books}>";
        }

    }
}
