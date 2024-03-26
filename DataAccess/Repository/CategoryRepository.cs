using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        public List<Category> GetAll() => CategoryDAO.Instance.GetAll();

        public Category GetById(int id) => CategoryDAO.Instance.GetById(id);

        public Category GetByName(string name) => CategoryDAO.Instance.GetByName(name);

        public void Create(Category t) => CategoryDAO.Instance.Create(t);

        public void Delete(int id) => CategoryDAO.Instance.Delete(id);

        public void Update(Category t) => CategoryDAO.Instance.Update(t);
    }
}
