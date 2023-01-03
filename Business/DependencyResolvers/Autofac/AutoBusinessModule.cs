using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Business.Homepage.Abstract;
using Business.Homepage.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Abstract.Homepage;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Homepage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutoBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance(); 
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance(); 
            builder.RegisterType<EfBrandDal>().As<IBrandDal>().SingleInstance(); 
            builder.RegisterType<BrandManager>().As<IBrandService>().SingleInstance();
            builder.RegisterType<EfColorDal>().As<IColorDal>().SingleInstance();
            builder.RegisterType<ColorManager>().As<IColorService>().SingleInstance();


            builder.RegisterType<EfNavbarDal>().As<INavbarDal>().SingleInstance();
            builder.RegisterType<NavbarManager>().As<INavbarService>().SingleInstance();
            builder.RegisterType<EfSelectedNavbarDal>().As<ISelectedNavbarDal>().SingleInstance();
            builder.RegisterType<SelectedNavbarManager>().As<ISelectedService>().SingleInstance();



            builder.RegisterType<UserCoreManager>().As<IUserCoreService>();
            builder.RegisterType<EfUserCoreDal>().As<IUserCoreDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
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
