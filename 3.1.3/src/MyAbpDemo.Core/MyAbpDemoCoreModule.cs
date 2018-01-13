using System.Reflection;
using Abp.Modules;

namespace MyAbpDemo
{
    public class MyAbpDemoCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
