using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAssignment
{
    internal class AggregationOperations
    {
        public List<BooksIssued> getBooksIssued(List<BooksDetails> list1, List<BooksRentalDetails> list2)
        {
            Dictionary<int, BooksDetails> dict = new Dictionary<int, BooksDetails>();
            List<BooksIssued> result = new List<BooksIssued>();
            foreach (BooksDetails book in list1)
            {
                dict.Add(book.booksId, book);
            }
            foreach (BooksRentalDetails booksRental in list2)
            {
                if (booksRental.status)
                {
                    BooksIssued booksIssued = new BooksIssued();
                    booksIssued.bookId = booksRental.booksId;
                    booksIssued.bookName = dict[booksRental.booksId].booksName;
                    booksIssued.bookIssued = booksRental.status;
                    booksIssued.bookIssuedUserName = booksRental.userName;
                    booksIssued.bookIssuedDate = booksRental.issueDate;
                    result.Add(booksIssued);
                }
            }
            return result;
        }

        public List<ReturnedBooks> getDataOfTwoOrMoreIssuedReturns(List<BooksRentalDetails> booksRentals)
        {
            Dictionary<string, ReturnedBooks> keyValuePairs = new Dictionary<string, ReturnedBooks>();
            List<ReturnedBooks> returnIssuedBooks = new List<ReturnedBooks>();
            foreach (BooksRentalDetails book in booksRentals)
            {
                if (keyValuePairs.ContainsKey(book.userName))
                {
                    keyValuePairs[book.userName].numberOfIssued++;
                    if (!book.status)
                        keyValuePairs[book.userName].numberOfReturns++;
                }
                else
                {
                    keyValuePairs.Add(book.userName, new ReturnedBooks());
                    keyValuePairs[book.userName].bookIssuedUserName = book.userName;
                    keyValuePairs[book.userName].numberOfIssued++;
                    if (!book.status)
                        keyValuePairs[book.userName].numberOfReturns++;
                }
            }
            foreach (var str in keyValuePairs.Keys)
            {
                if (keyValuePairs[str].numberOfIssued > 1 || keyValuePairs[str].numberOfReturns > 1)
                    returnIssuedBooks.Add(keyValuePairs[str]);
            }
            return returnIssuedBooks;
        }
    }
}
