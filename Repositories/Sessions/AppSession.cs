using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using NorthWind.API.Helpers;
using Npgsql;
using Smooth.IoC.UnitOfWork;
using Smooth.IoC.UnitOfWork.Abstractions;
using Smooth.IoC.UnitOfWork.Interfaces;
using System;
using System.IO;

namespace NorthWind.API.Repositories
{
    public interface IAppSession : ISession
    { }

    public class AppSession : Session<NpgsqlConnection>, IAppSession
    {
        public AppSession(IDbFactory session, IOptions<DatabaseOptions> databaseOptions)
                : base(session, connectionString: databaseOptions.Value.DefaultConnection)
        {
            Dapper.FastCrud.OrmConfiguration.DefaultDialect = Dapper.FastCrud.SqlDialect.PostgreSql;
        }
    }
}