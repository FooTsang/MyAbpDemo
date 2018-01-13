using System.Reflection;
using Abp.Modules;

namespace MyAbpDemo
{
    [DependsOn(typeof(MyAbpDemoCoreModule))]
    public class MyAbpDemoApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
