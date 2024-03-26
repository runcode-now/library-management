using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BookDAO
    {
        LibraryManagementContext context = new LibraryManagementContext();

        private static BookDAO instance = null;
        private static readonly object instanceLock = new object();
        public static BookDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Book> GetAll()
        {
            var book = new List<Book>();
            book = context.Books.ToList();
            return book;
        }


        public Book GetById(int id)
        {
            Book book = null;
            try
            {
                book = context.Books.SingleOrDefault(x => x.BookId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return book;
        }

        public void Create(Book t)
        {
            try
            {
                Book acc = GetById(t.BookId);
                if (acc == null)
                {
                    context.Books.Add(t);
                    context.SaveChanges();
                }
                else throw new Exception("This book is exist");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                Book acc = GetById(id);
                if (acc != null)
                {
                    context.Books.Remove(acc);
                    context.SaveChanges();
                }
                else throw new Exception("This book is not exist");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Book t)
        {
            try
            {
                Book acc = GetById(t.BookId);
                if (acc != null)
                {
                    context.Books.Update(t);
                    context.SaveChanges();
                }
                else throw new Exception("This book is not exist");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
