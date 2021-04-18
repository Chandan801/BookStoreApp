using BookStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Repos
{
    public class BookRepo
    {
        public List<BookClass> GetAllBooks() {
            return DataSource();
        }
        public BookClass GetBook(int Id) 
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();
            
        }
        public List<BookClass> SearchBooks(string bookName,string authorName) {
            return DataSource().Where(x => x.Title.Contains(bookName) || x.Author.Contains( authorName)).ToList();
        }

        internal BookClass GetBook()
        {
            throw new NotImplementedException();
        }

        private List<BookClass> DataSource()
        {
            return new List<BookClass>
            {
                new BookClass(){Id=1,Title="Java",Author="Cko"},
                 new BookClass(){Id=2,Title="c#",Author="prem"},
                  new BookClass(){Id=3,Title="Advance Java",Author="chand"},
                   new BookClass(){Id=4,Title="Javascript",Author="kumar"},
                    new BookClass(){Id=5,Title="scripting",Author="Champak"},
            };
        }

        internal List<BookClass> SearchBooks()
        {
            throw new NotImplementedException();
        }
    }
}
