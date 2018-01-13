using Abp.Application.Services;

namespace MyAbpDemo
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MyAbpDemoAppServiceBase : ApplicationService
    {
        protected MyAbpDemoAppServiceBase()
        {
            LocalizationSourceName = MyAbpDemoConsts.LocalizationSourceName;
        }
    }
}