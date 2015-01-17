using System;
using System.Web.Mvc;
using System.Web.Routing;
using MvcAppPersianDatePicker.CustomModelBinders;

namespace MvcAppPersianDatePicker
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ModelBinders.Binders.Add(typeof(DateTime), new PersianDateModelBinder());
        }
    }
}