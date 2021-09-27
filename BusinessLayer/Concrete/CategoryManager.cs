using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
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
        ICateforyDal _cateforyDal;

        public CategoryManager(ICateforyDal cateforyDal)
        {
            _cateforyDal = cateforyDal;
        }

        public void CategoryAdd(Category category)
        {
            _cateforyDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _cateforyDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _cateforyDal.Update(category);
        }

        public Category GetById(int id)
        {
            return _cateforyDal.GetByID(id);
        }

        public List<Category> GetList()
        {
            return _cateforyDal.GetListAll();
        }
    }
}
