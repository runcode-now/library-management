using BusinessObject.Models;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AccountDAO
    {
        LibraryManagementContext context = new LibraryManagementContext();
        //dasdasdasdasd
        private static AccountDAO instance = null;
        private static readonly object instanceLock = new object();
        public static AccountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Account> GetAll()
        {
            var acc = new List<Account>();
            acc = context.Accounts.ToList();
            return acc;
        }


        public Account GetById(int id)
        {
            Account acc = null;
            try
            {
                acc = context.Accounts.SingleOrDefault(x => x.AccountId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return acc;
        }

        public void Create(Account t)
        {
            try
            {
                Account acc = GetById(t.AccountId);
                if (acc == null)
                {
                    context.Accounts.Add(t);
                    context.SaveChanges();
                }
                else throw new Exception("This account is exist");
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
                Account acc = GetById(id);
                if (acc != null)
                {
                    context.Accounts.Remove(acc);
                    context.SaveChanges();
                }
                else throw new Exception("This account is not exist");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Account t)
        {
            try
            {
                Account acc = GetById(t.AccountId);
                if (acc != null)
                {
                    context.Accounts.Update(t);
                    context.SaveChanges();
                }
                else throw new Exception("This account is not exist");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Account CheckAccount(string username)
        {
            try
            {
                Account acc = GetAll().SingleOrDefault(x => x.AccountUsername.Equals(username));
                return acc;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string EncodeToSHA1(string str)
        {
            String secure = "wodmtmpa@eiknsiovichdaa";
            str += secure;

            String result = "";

            try
            {
                byte[] dataBytes = Encoding.UTF8.GetBytes(str);
                using (SHA1 sha1 = SHA1.Create())
                {
                    byte[] hashBytes = sha1.ComputeHash(dataBytes);
                    result = Convert.ToBase64String(hashBytes);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return result;
        }

    }
}
