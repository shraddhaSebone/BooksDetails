using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAssignment
{
    internal class Execution
    {
        static void Main(string[] args)
        {
            BooksDetailsDummyData booksDetailsDummyData = new BooksDetailsDummyData();
            List<BooksDetails> list1 = booksDetailsDummyData.getBooksDetails();
            foreach (BooksDetails book in list1)
            {
              Console.WriteLine($"{book.booksId}  {book.booksName}  {book.booksISBN}  {book.booksPrice}  {book.booksAuthor}");
            }
            Console.WriteLine($"-------------------------------------------------------------------------------------------");

            BooksRentalDummyData booksRentalDummyData = new BooksRentalDummyData();
            List<BooksRentalDetails> list2 = booksRentalDummyData.getBooksRentalDetails();
            foreach(BooksRentalDetails book in list2)
            {
                Console.WriteLine($"{book.userId} {book.userName}  {book.booksId}  {book.issueDate}  {book.status}  {book.returnDate}  {book.pinCode}");
            }//{book.issueDate.ToLongDateString()}
            Console.WriteLine($"-------------------------------------------------------------------------------------------");



            AggregationOperations aggregationOperations = new AggregationOperations();
            List<BooksIssued> list3 = aggregationOperations.getBooksIssued(list1, list2);
            foreach(BooksIssued data in list3)
            {
                Console.WriteLine($"{data.bookId}  {data.bookName}  {data.bookIssued}  {data.bookIssuedUserName}  {data.bookIssuedDate}");
            }

            Console.WriteLine($"-------------------------------------------------------------------------------------------");

            List<ReturnedBooks> list4 = aggregationOperations.getDataOfTwoOrMoreIssuedReturns(list2);
            foreach(ReturnedBooks data in list4)
            {
                Console.WriteLine($"{data.numberOfIssued}  {data.bookIssuedUserName}  {data.numberOfReturns}");
            }
        }
    }
}
