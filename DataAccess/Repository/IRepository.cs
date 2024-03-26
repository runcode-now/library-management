using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IRepository<T>
    {
        public List<T> GetAll();

        public T GetById(int id);

        public void Create(T t);

        public void Update(T t);

        public void Delete(int id);

    }
}
