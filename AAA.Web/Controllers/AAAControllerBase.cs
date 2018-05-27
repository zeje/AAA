using Abp.Web.Mvc.Controllers;

namespace AAA.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class AAAControllerBase : AbpController
    {
        protected AAAControllerBase()
        {
            LocalizationSourceName = AAAConsts.LocalizationSourceName;
        }
    }
}