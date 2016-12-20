using TennisClub2.Migrations;
using TennisClub2.Models;
using Microsoft.Owin;
using Owin;
using System.Data.Entity;

[assembly: OwinStartupAttribute(typeof(TennisClub2.Startup))]
namespace TennisClub2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogDbContext, Configuration>());
                       ConfigureAuth (app);
        }
    }
}
