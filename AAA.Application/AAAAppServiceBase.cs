using Abp.Application.Services;

namespace AAA
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AAAAppServiceBase : ApplicationService
    {
        protected AAAAppServiceBase()
        {
            LocalizationSourceName = AAAConsts.LocalizationSourceName;
        }
    }
}