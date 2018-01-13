using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using MyAbpDemo.EntityFramework;

namespace MyAbpDemo
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(MyAbpDemoCoreModule))]
    public class MyAbpDemoDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<MyAbpDemoDbContext>(null);
        }
    }
}
