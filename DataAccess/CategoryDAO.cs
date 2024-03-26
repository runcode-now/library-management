using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDAO
    {
        LibraryManagementContext context = new LibraryManagementContext();

        private static CategoryDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Category> GetAll()
        {
            var cate = new List<Category>();
            cate = context.Categories.ToList();
            return cate;
        }


        public Category GetById(int id)
        {
            Category cate = null;
            try
            {
                cate = context.Categories.SingleOrDefault(x => x.CategoryId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cate;
        }
        
        public Category GetByName(string name)
        {
            Category cate = null;
            try
            {
                cate = context.Categories.SingleOrDefault(x => x.CategoryName == name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cate;
        }

        public void Create(Category t)
        {
            try
            {
                Category acc = GetById(t.CategoryId);
                if (acc == null)
                {
                    context.Categories.Add(t);
                    context.SaveChanges();
                }
                else throw new Exception("This category is exist");
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
                Category cate = GetById(id);
                if (cate != null)
                {
                    context.Categories.Remove(cate);
                    context.SaveChanges();
                }
                else throw new Exception("This category is not exist");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Category t)
        {
            try
            {
                Category acc = GetById(t.CategoryId);
                if (acc != null)
                {
                    context.Categories.Update(t);
                    context.SaveChanges();
                }
                else throw new Exception("This category is not exist");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
