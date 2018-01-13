using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace MyAbpDemo
{
    [DependsOn(typeof(AbpWebApiModule), typeof(MyAbpDemoApplicationModule))]
    public class MyAbpDemoWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(MyAbpDemoApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
