using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangyWeb_Models;

namespace Tangy_Business.Repository.IRepository
{
    public interface IRepositoryCategory
    {
        public CategoryDto Create(CategoryDto objectDto);
        public CategoryDto Update(CategoryDto objectDto);
        public int Delete(int id);
        public CategoryDto Get(int id);
        public IEnumerable<CategoryDto> GetAll(); 
    }
}
