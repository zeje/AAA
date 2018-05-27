using Abp.Web.Mvc.Views;

namespace AAA.Web.Views
{
    public abstract class AAAWebViewPageBase : AAAWebViewPageBase<dynamic>
    {

    }

    public abstract class AAAWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AAAWebViewPageBase()
        {
            LocalizationSourceName = AAAConsts.LocalizationSourceName;
        }
    }
}