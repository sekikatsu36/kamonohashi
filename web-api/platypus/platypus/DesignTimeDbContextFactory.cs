using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Nssol.Platypus.DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Nssol.Platypus
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CommonDbContext>
    {
        public CommonDbContext CreateDbContext(string[] args)
        {
            // DB 接続情報を設定しているファイルから取得
            string defaultConnection = CommonDbContext.readDefaultConnection();

            var builder = new DbContextOptionsBuilder<CommonDbContext>();
            builder.UseNpgsql(defaultConnection);

            Startup.DefaultConnectionString = defaultConnection;
            return new CommonDbContext(builder.Options);
        }
    }
}
