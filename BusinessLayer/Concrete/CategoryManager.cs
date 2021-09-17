using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }

        public void Add(Category category)
        {
            efCategoryRepository.Add(category);
        }

        public void Delete(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public List<Category> GetAll()
        {
            return efCategoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return efCategoryRepository.GetById(id);
        }

        public void Update(Category category)
        {
            efCategoryRepository.Update(category);
        }
    }
}
