using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HistoryBookDAO
    {
        LibraryManagementContext context = new LibraryManagementContext();

        private static HistoryBookDAO instance = null;
        private static readonly object instanceLock = new object();
        public static HistoryBookDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new HistoryBookDAO();
                    }
                    return instance;
                }
            }
        }

        public List<HistoryBook> GetAll()
        {
            var cate = new List<HistoryBook>();
            cate = context.HistoryBooks.ToList();
            return cate;
        }


        public HistoryBook GetById(int id)
        {
            HistoryBook cate = null;
            try
            {
                cate = context.HistoryBooks.SingleOrDefault(x => x.HistoryId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cate;
        }

        public List<HistoryBook> GetByStatus(string status)
        {
            List<HistoryBook> cate = null;
            try
            {
                cate = context.HistoryBooks.Where(x => x.HistoryStatus.Equals(status)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cate;
        }

        public void Create(HistoryBook t)
        {
            try
            {
                HistoryBook acc = GetById(t.HistoryId);
                if (acc == null)
                {
                    context.HistoryBooks.Add(t);
                    context.SaveChanges();
                }
                else throw new Exception("This history is exist");
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
                HistoryBook cate = GetById(id);
                if (cate != null)
                {
                    context.HistoryBooks.Remove(cate);
                    context.SaveChanges();
                }
                else throw new Exception("This history is not exist");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(HistoryBook t)
        {
            try
            {
                HistoryBook acc = GetById(t.HistoryId);
                if (acc != null)
                {
                    context.HistoryBooks.Update(t);
                    context.SaveChanges();
                }
                else throw new Exception("This history is not exist");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public HistoryBook CheckExit(int bookId, int accId)
        {
            try
            {
                HistoryBook acc = GetAll().FirstOrDefault(x => x.AccountId == accId 
                                                            && x.BookId == bookId
                                                            && x.HistoryStatus != null
                                                            && x.HistoryStatus.Equals("waiting"));
                return acc;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
