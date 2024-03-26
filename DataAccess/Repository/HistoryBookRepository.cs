using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class HistoryBookRepository : IRepository<HistoryBook>
    {
        public List<HistoryBook> GetAll() => HistoryBookDAO.Instance.GetAll();

        public HistoryBook GetById(int id) => HistoryBookDAO.Instance.GetById(id);

        public List<HistoryBook> GetByStatus(string status) => HistoryBookDAO.Instance.GetByStatus(status);

        public void Create(HistoryBook t) => HistoryBookDAO.Instance.Create(t);

        public void Delete(int id) => HistoryBookDAO.Instance.Delete(id);

        public void Update(HistoryBook t) => HistoryBookDAO.Instance.Update(t);
        public HistoryBook CheckExit(int bookId, int accId) => HistoryBookDAO.Instance.CheckExit(bookId, accId);
    }
    
}
