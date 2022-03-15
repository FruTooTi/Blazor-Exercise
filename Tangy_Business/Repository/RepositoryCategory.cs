using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tangy_Business.Repository.IRepository;
using TangyWeb_Models;
using Tangy_DataAccess;
using Tangy_DataAccess.Data;
using AutoMapper;

namespace Tangy_Business.Repository
{
    public class RepositoryCategory : IRepositoryCategory
    {
        private ApplicationDbContext _db;
        private IMapper _Mapper;
        public RepositoryCategory(ApplicationDbContext db, IMapper Mapper)
        {
            _db = db;
            _Mapper = Mapper;
        }
        public CategoryDto Create(CategoryDto objectDto)
        {
            //Category category = new Category()
            //{
            //    Name = objectDto.Name,
            //    Id = objectDto.Id,
            //    CreatedDate = DateTime.Now
            //};
            var category = _Mapper.Map<CategoryDto, Category>(objectDto);
            category.CreatedDate = DateTime.Now;
            _db.Categories.Add(category);
            _db.SaveChanges();

            return _Mapper.Map<Category, CategoryDto>(category);
        }

        public int Delete(int id)
        {
            var category = _db.Categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _db.Remove(category);
                return _db.SaveChanges();
            }
            return 0;
        }

        public CategoryDto Get(int id)
        {
            var category = _db.Categories.FirstOrDefault(c => c.Id == id);
            var categoryDto = _Mapper.Map<Category, CategoryDto>(category);
            if (categoryDto != null)
                return categoryDto;
            return null;
        }

        public IEnumerable<CategoryDto> GetAll()
        {
            var obj = _Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDto>>(_db.Categories.ToList());
            if (obj != null)
                return obj;
            return null;
        }

        public CategoryDto Update(CategoryDto objectDto)
        {
            var obj = _db.Categories.FirstOrDefault(c => c.Id == objectDto.Id);
            if(obj != null)
            {
                obj.Name = objectDto.Name;
                _db.Update(obj);
                _db.SaveChanges();
                return _Mapper.Map<Category, CategoryDto>(obj);
            }
            return objectDto;
        }
    }
}
