using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using AutoMapper;
using NorthWind.API.Repositories;
using IdentityModel;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Smooth.IoC.UnitOfWork;
using Smooth.IoC.UnitOfWork.Interfaces;

namespace NorthWind.API.Controllers.Base
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BaseController : Controller
    {
        protected readonly IDbFactory _dbFactory;
        protected readonly IMapper _mapper;
        protected string _userId => getUserId();

        public BaseController(IDbFactory dbFactory, IMapper mapper)
        {
            this._dbFactory = dbFactory;
            this._mapper = mapper;
        }

        protected ISession OpenSession()
        {
            return this._dbFactory.Create<IAppSession>();
        }

        private string getUserId()
        {
            return HttpContext.User?.Claims?.FirstOrDefault(p => p.Type == JwtClaimTypes.Subject)?.Value;
        }

        protected IEnumerable<Claim> getUserClaims()
        {
            return HttpContext.User?.Claims;
        }
    }
}