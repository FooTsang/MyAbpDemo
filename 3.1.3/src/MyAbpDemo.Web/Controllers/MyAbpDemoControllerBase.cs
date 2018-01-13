using Abp.Web.Mvc.Controllers;

namespace MyAbpDemo.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class MyAbpDemoControllerBase : AbpController
    {
        protected MyAbpDemoControllerBase()
        {
            LocalizationSourceName = MyAbpDemoConsts.LocalizationSourceName;
        }
    }
}