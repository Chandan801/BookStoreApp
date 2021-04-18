using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All Books";
        }
        public string GetBook(int id)
        {
            return $"Id of the book is {id}";
        }
        public string SearchBooks(string bookName,string authorName)
        {
            return $"Book name is {bookName} and Author name is {authorName}";
        }
    }
}
