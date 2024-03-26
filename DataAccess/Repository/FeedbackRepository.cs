using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class FeedbackRepository : IRepository<Feedback>
    {
        LibraryManagementContext context = new LibraryManagementContext();

        public List<Feedback> GetAll() => context.Feedbacks.ToList();

        public Feedback? GetById(int id) => context.Feedbacks.SingleOrDefault(x => x.FeedbackId == id);

        public void Create(Feedback t)
        {
            try
            {
                Feedback acc = GetById(t.FeedbackId);
                if (acc == null) context.Feedbacks.Add(t);
                else throw new Exception("This feedback is exist");
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
                Feedback acc = GetById(id);
                if (acc != null) context.Feedbacks.Remove(acc);
                else throw new Exception("This feedback is not exist");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Feedback t)
        {
            try
            {
                Feedback acc = GetById(t.FeedbackId);
                if (acc != null) context.Feedbacks.Update(t);
                else throw new Exception("This feedback is not exist");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
