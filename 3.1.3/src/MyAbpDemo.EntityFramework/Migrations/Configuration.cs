using System.Data.Entity.Migrations;

namespace MyAbpDemo.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MyAbpDemo.EntityFramework.MyAbpDemoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MyAbpDemo";
        }

        protected override void Seed(MyAbpDemo.EntityFramework.MyAbpDemoDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
