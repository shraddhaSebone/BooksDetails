using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAssignment
{
    internal class BooksRentalDetails
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public int booksId { get; set; }
        public DateTime issueDate { get; set; }
        public bool status { get; set; }
        public DateTime returnDate { get; set; }
        public int pinCode { get; set; }
        public BooksRentalDetails() { }
        public BooksRentalDetails(int userId, string userName, int booksId, DateTime issueDate, bool status, DateTime returnDate, int pinCode)
        {
            this.userId = userId;
            this.userName = userName;
            this.booksId = booksId;
            this.issueDate = issueDate;
            this.status = status;
            this.pinCode = pinCode;

        }
    }
}
