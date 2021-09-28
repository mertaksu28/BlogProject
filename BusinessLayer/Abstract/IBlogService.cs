using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        Blog GetById(int id);
        List<Blog> GetBlogListWithCategory();
        void Add(Blog blog);
        void Delete(Blog blog);
        void Update(Blog blog);
    }
}
