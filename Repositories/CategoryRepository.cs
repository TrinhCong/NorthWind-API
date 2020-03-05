using NorthWind.API.Models;
using Smooth.IoC.Repository.UnitOfWork;
using Smooth.IoC.UnitOfWork.Interfaces;

namespace NorthWind.API.Repositories
{
    public interface ICategoryRepository : IRepository<Category, int>
    {
        
    }

    public class CategoryRepository : Repository<Category, int>, ICategoryRepository
    {
        protected CategoryRepository(IDbFactory factory) : base(factory)
        {
            
        }
        
    }
}
