using BookStoreApp.Models;
using BookStoreApp.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepo _bookRepo=null;
        public BookController()
        {
            _bookRepo = new BookRepo();
        }
        public List<BookClass> GetAllBooks()
        {
            return _bookRepo.GetAllBooks();
        }

        public BookClass GetBook(int Id)
        {
            return _bookRepo.GetBook();
                
        }
        public List<BookClass> SearchBooks(string bookName,string authorName)
        {
            return _bookRepo.SearchBooks();
        }
    }
}
