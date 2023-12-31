﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System
{
    public class Books
    {
        private int bookId { get; set; }
        private string descriptions { get; set; }

        private string bookName { get; set; }

        private string path = @"C:\\Test";
        private string pathFile = @$"C:\\Test\books.txt";

        public Books()
        {

        }
        public Books(int bookId,string descriptions , string bookName)
        {
            this.bookId = bookId;
            this.descriptions = descriptions;
            this.bookName = bookName;

        }
        //Add book admin
        public void createBook()
        {
            Console.WriteLine("Enter Book name");
            string bookName = Console.ReadLine();
            Console.WriteLine("Enter Book Description");
            string descriptions = Console.ReadLine();
            Books boks=new Books(1, descriptions , bookName);

            //Save to book.txt
            //path
            
            if (File.Exists(pathFile))
            {
                string[] allBooks = File.ReadAllLines(pathFile);
                int noBooks = allBooks.Length;
                noBooks++;
                File.AppendAllText(pathFile, $"\n{noBooks}:{bookName}:{descriptions}");

            }
            else
            {
                File.WriteAllText(pathFile, $"1:{bookName}:{descriptions}");
            }

    
        }
        //Display books
        public void displayBooks(String userId)
        {
            string[] booksExisting = File.ReadAllLines(pathFile);

            foreach(string book in booksExisting )
            {
                string[] bookDetails = book.Split(":");
                String bookID = bookDetails[0];


				Console.WriteLine($"{bookDetails[0]} {bookDetails[1]}");

            }



            Console.WriteLine("SELECT A BOOK YOU WANT TO BUY: ");
            String userChoice = Console.ReadLine();

            Console.WriteLine($"BookId {userChoice} userID {userId}");

            Orders order =new Orders(int.Parse(userId), int.Parse(userChoice));
            order.buyBook();

        }




    }
}
