using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAssignment
{
    internal class BooksRentalDummyData
    {
       public List<BooksRentalDetails> getBooksRentalDetails()
        {
            List<BooksRentalDetails> booksRentalDetails = new List<BooksRentalDetails>();
            BooksRentalDetails booksRentalDetails1 = new BooksRentalDetails(1, "Raj" , 101 ,new DateTime(2022,12,2) ,true ,new DateTime(2022,12,20),451001);
            BooksRentalDetails booksRentalDetails2 = new BooksRentalDetails(2, "Bhanu",102, new DateTime(2022,10,10),false,new DateTime(2022,10,11),451002);
            BooksRentalDetails booksRentalDetails3 = new BooksRentalDetails(3, "Shreya",103,new DateTime(2022,9,8),true,new DateTime(2022,9,8),451008);
            BooksRentalDetails booksRentalDetails4 = new BooksRentalDetails(4, "Varsha",104,new DateTime(2022,6,28),false,new DateTime(2022,7,12),451006);
            BooksRentalDetails booksRentalDetails5 = new BooksRentalDetails(5, "Vivek",105,new DateTime(2022,6,1),true,new DateTime(2022,9,18),451007);
            BooksRentalDetails booksRentalDetails6 = new BooksRentalDetails(6, "Sajal",106,new DateTime(2022,4,30),false,new DateTime(2022,12,9),451001);
            BooksRentalDetails booksRentalDetails7 = new BooksRentalDetails(7, "Aaliya",101,new DateTime(2022,9,17),true,new DateTime(2022,10,15),451009);
            BooksRentalDetails booksRentalDetails8 = new BooksRentalDetails(8, "Bhawana",108,new DateTime(2022,2,27),false,new DateTime(2022,10,27),451002);
            BooksRentalDetails booksRentalDetails9 = new BooksRentalDetails(9, "Raj",109,new DateTime(2022,3,19),true,new DateTime(2022,6,5),451004);
            BooksRentalDetails booksRentalDetails10 = new BooksRentalDetails(10,"Bhanu",110,new DateTime(2022,5,21),true,new DateTime(2022,11,26),451003);
            booksRentalDetails.Add(booksRentalDetails1);
            booksRentalDetails.Add(booksRentalDetails2);
            booksRentalDetails.Add(booksRentalDetails3);
            booksRentalDetails.Add(booksRentalDetails4);
            booksRentalDetails.Add(booksRentalDetails5);               
            booksRentalDetails.Add(booksRentalDetails6);
            booksRentalDetails.Add(booksRentalDetails7);
            booksRentalDetails.Add(booksRentalDetails8);
            booksRentalDetails.Add(booksRentalDetails9);
            booksRentalDetails.Add(booksRentalDetails10);

             return booksRentalDetails;
       }
    }
}
//userId   userName    bookId
//1	        Raj	        101	    12-02-2022	TRUE	03-03-2022	1220
//2	        Bhanu	    102 	10-12-2021	FALSE	11-12-2022	987
//3	        Shreya	    103	    09-03-2022	TRUE	26-06-2022	3452
//4	        Varsha	    104 	23-09-2022	FALSE	01-10-2022	1119
//5     	Vivek	    105	    12-02-2022	TRUE	10-01-2023	6541
//6	        Sajal	    106 	04-05-2022	TRUE	16-05-2022	1090
//7     	Aaliya	    107	    02-08-2022	TRUE	08-08-2022	7812
//8     	Bhawana	    108	    12-10-2022	FALSE	 10-12-2022	1001
//9     	Raj	        109	    03-07-2022	TRUE	07-12-2022	7367
//10	    Bhanu	    110	    17-05-2022	TRUE	03-01-2022	3783
