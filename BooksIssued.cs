using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAssignment
{
    internal class BooksIssued
    {
        public int bookId { get; set; }
        public string bookName { get; set; }
        public bool bookIssued { get; set; }
        public string bookIssuedUserName { get; set; }
        public DateTime bookIssuedDate { get; set; }
        public BooksIssued() { }
        public BooksIssued(int bookId, string bookName, bool bookIssued, string bookIssuedUserName, DateTime bookIssuedDate)
        {
            this.bookId = bookId;
            this.bookName = bookName;
            this.bookIssued = bookIssued;
            this.bookIssuedUserName = bookIssuedUserName;
            this.bookIssuedDate = bookIssuedDate;
        }
    }
}
