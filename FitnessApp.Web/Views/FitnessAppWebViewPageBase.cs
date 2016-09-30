using Abp.Web.Mvc.Views;

namespace FitnessApp.Web.Views
{
    public abstract class FitnessAppWebViewPageBase : FitnessAppWebViewPageBase<dynamic>
    {

    }

    public abstract class FitnessAppWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected FitnessAppWebViewPageBase()
        {
            LocalizationSourceName = FitnessAppConsts.LocalizationSourceName;
        }
    }
}