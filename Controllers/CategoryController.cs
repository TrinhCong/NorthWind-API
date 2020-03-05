using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using NorthWind.API.Controllers.Base;
using NorthWind.API.Models;
using NorthWind.API.Models.DTO;
using NorthWind.API.Repositories;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Smooth.IoC.UnitOfWork;
using Smooth.IoC.UnitOfWork.Interfaces;

namespace NorthWind.API.Controllers
{
    public class CategoryController : BaseController
    {
        protected readonly ICategoryRepository _categoryRepository;

        public CategoryController(
            IDbFactory dbFactory,
            IMapper mapper,
            ICategoryRepository categoryRepository
            ) : base(dbFactory, mapper)
        {
             _categoryRepository=categoryRepository;
        }

        [HttpPost]
        [Route("api/[controller]/getAll")]
        public async Task<RestBase> getAll()
        {
            using(var session = _dbFactory.Create<IAppSession>())
            {
                return new RestData
                {
                    data = _categoryRepository.GetAll(session)
                };
            }
        }

    }
}