using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract.IEframework;
using DataAccess.Concrete.Eframework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
   public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            
                builder.RegisterType<CarServiceManager>().As<ICarService>().SingleInstance();
                builder.RegisterType<CarDal>().As<ICarDal>().SingleInstance();
            
            
                builder.RegisterType<BrandServiceManager>().As<IBrandService>().SingleInstance();
                builder.RegisterType<BrandDal>().As<IBrandDal>().SingleInstance();
            
            
                builder.RegisterType<CategoryServiceManager>().As<ICategoryService>().SingleInstance();
                builder.RegisterType<CategoryDal>().As<ICategoryDal>().SingleInstance();
            
            
                builder.RegisterType<RentCarServiceManager>().As<IRentCarService>().SingleInstance();
                builder.RegisterType<RentalDal>().As<IRentalDal>().SingleInstance();
            
            
                builder.RegisterType<CustomerServiceManager>().As<ICustomerService>().SingleInstance();
                builder.RegisterType<CustomerDal>().As<ICustomerDal>().SingleInstance();
            
            
                builder.RegisterType<UserServiceManager>().As<IUserService>().SingleInstance();
                builder.RegisterType<UserDal>().As<IUserDal>().SingleInstance();

            
            
                builder.RegisterType<ColorServiceManager>().As<IColorService>().SingleInstance();
                builder.RegisterType<ColorDal>().As<IColorDal>().SingleInstance();
            
                


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }

    }
}
