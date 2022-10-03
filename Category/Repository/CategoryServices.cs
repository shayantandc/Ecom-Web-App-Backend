using Category.Models;
using System.Collections.Generic;
using System.Linq;

namespace Category.Repository
{
    public class CategoryServices : ICategory
    {
        private readonly EcomContext _data;

        public CategoryServices(EcomContext data)
        {
            _data = data;
        }

        public IEnumerable<EcomCategory> AddCategory(EcomCategory cat)
        {
            
            _data.EcomCategory.Add(cat);
            _data.SaveChanges();
            return GetAllCategory();
        }

        public IEnumerable<EcomCategory> GetAllCategory()
        {
            return _data.EcomCategory.ToList();
        }

        public EcomCategory getCategoryById(int id)
        {
            return _data.EcomCategory.FirstOrDefault(x => x.CategoryId == id);
        }




    }
}
