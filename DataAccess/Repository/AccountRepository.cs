using BusinessObject.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class AccountRepository : IRepository<Account>
    {
        public List<Account> GetAll() => AccountDAO.Instance.GetAll();

        public Account GetById(int id) => AccountDAO.Instance.GetById(id);

        public void Create(Account t) => AccountDAO.Instance.Create(t);

        public void Delete(int id) => AccountDAO.Instance.Delete(id);

        public void Update(Account t) => AccountDAO.Instance.Update(t);

        public Account CheckAccount(string username) => AccountDAO.Instance.CheckAccount(username);

        public string EncodeToSHA1(string str) => AccountDAO.Instance.EncodeToSHA1(str);
    }
}
