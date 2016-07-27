using FluentValidation.Mvc;
using FrameWork.Data;
using FrameWork.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FrameWork.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //初始化数据库
            Database.SetInitializer(new GoalsSampleData());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //实体验证组件
            FluentValidationModelValidatorProvider.Configure();
            //依赖注入Service
            Bootstrapper.Run();
        }
    }
}
