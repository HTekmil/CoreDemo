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

        public Category TGetById(int id)
        {
            return _cateforyDal.GetByID(id);
        }

        public List<Category> GetList()
        {
            return _cateforyDal.GetListAll();
        }

        public void TAdd(Category t)
        {
            _cateforyDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _cateforyDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _cateforyDal.Update(t);
        }
    }
}
