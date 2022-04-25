using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAssignment
{
    internal class BooksDetails
    {
        public int booksId { get; set; }
        public string booksName { get; set; }
        public string booksISBN { get; set; }
        public int booksPrice { get; set; }
        public string booksAuthor { get; set; }

        public BooksDetails() { }
        public BooksDetails(int booksId, string booksName, string booksISBN, int booksPrice, string booksAuthor)
        {
            this.booksId = booksId;
            this.booksName = booksName;
            this.booksISBN = booksISBN;
            this.booksPrice = booksPrice;
            this.booksAuthor = booksAuthor;
        }
    }
}
