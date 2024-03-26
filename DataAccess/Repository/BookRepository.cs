using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class BookRepository : IRepository<Book>
    {
        public List<Book> GetAll() => BookDAO.Instance.GetAll();

        public Book GetById(int id) => BookDAO.Instance.GetById(id);

        public void Create(Book t) => BookDAO.Instance.Create(t);

        public void Delete(int id) => BookDAO.Instance.Delete(id);

        public void Update(Book t) => BookDAO.Instance.Update(t);

    }
}
