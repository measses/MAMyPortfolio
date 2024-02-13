using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLayer.Services;
using DataLayer.Abstract;
using Entities;

namespace BussinesLayer.Content
{
    public class BlogManager : IGenericService<BlogDetail>,IBlogService
    {
        private readonly IBlog _blog;
        public BlogManager(IBlog blog)
        {
            _blog = blog;
        }

        public void TAdd(BlogDetail t)
        {
           _blog.Add(t);
        }

        public List<BlogDetail> TGetAll()
        {
            return _blog.GetAll();
        }

        public BlogDetail TGetById(int id)
        {
            return (BlogDetail)_blog.GetById(id);
        }

        public void TRemove(BlogDetail t)
        {
            _blog.Delete(t);
        }

        public void TUpdate(BlogDetail t)
        {
            _blog.Update(t);
        }
    }
}
