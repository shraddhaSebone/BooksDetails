using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAssignment
{
    internal class BooksDetailsDummyData
    {
        public List<BooksDetails> getBooksDetails()
        {
            List<BooksDetails> booksDetails = new List<BooksDetails>();
            BooksDetails booksDetails1 = new BooksDetails(101, "The Pilgrim's Progress", "IB12022",140, "John Bunyan");
            BooksDetails booksDetails2 = new BooksDetails(102, "Robinson Crusoe", "373C", 640, "Daniel Defoe");
            BooksDetails booksDetails3 = new BooksDetails(103, "Gulliver's Travels", "WR387", 546, "Jonathan Swift");
            BooksDetails booksDetails4 = new BooksDetails(104, "Jonathan Swift", "AB822", 700, "Richardson");
            BooksDetails booksDetails5 = new BooksDetails(105, "Clarissa", "TN373", 120, "Richardson");
            BooksDetails booksDetails6 = new BooksDetails(106, "Tom Jones", "UH862", 890, "Henry Fielding");
            BooksDetails booksDetails7 = new BooksDetails(107, "English", "GA297", 300, "Agrawal");
            BooksDetails booksDetails8 = new BooksDetails(108, "Hindi", "HN011", 370, "R Chouhan");
            BooksDetails booksDetails9 = new BooksDetails(109, "Science", "LM198", 690, "Jay");
            BooksDetails booksDetails10 = new BooksDetails(110, "Hindi", "YH013", 230, "Kishore");

            booksDetails.Add(booksDetails1);
            booksDetails.Add(booksDetails2);
            booksDetails.Add(booksDetails3);
            booksDetails.Add(booksDetails4);
            booksDetails.Add(booksDetails5);
            booksDetails.Add(booksDetails6);
            booksDetails.Add(booksDetails7);
            booksDetails.Add(booksDetails8);
            booksDetails.Add(booksDetails9);
            booksDetails.Add(booksDetails10);

            return booksDetails;

        }
    }
}
