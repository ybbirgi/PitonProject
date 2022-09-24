using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<DailyReportManager>().As<IDailyReportService>().SingleInstance();
            builder.RegisterType<WeeklyReportManager>().As<IWeeklyReportService>().SingleInstance();
            builder.RegisterType<MonthlyReportManager>().As<IMonthlyReportService>().SingleInstance();
            builder.RegisterType<EfUserDao>().As<IUserDao>().SingleInstance();
            builder.RegisterType<EfDailyReportDao>().As<IDailyReportDao>().SingleInstance();
            builder.RegisterType<EfWeeklyReportDao>().As<IWeeklyReportDao>().SingleInstance();
            builder.RegisterType<EfMonthlyReportDao>().As<IMonthlyReportDao>().SingleInstance();
            builder.RegisterType<AuthManager>().As< IAuthService > ();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
