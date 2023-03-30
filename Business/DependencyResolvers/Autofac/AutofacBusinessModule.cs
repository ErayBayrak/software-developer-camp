using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
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
            //SingleInstance çalışma zamanında bir kere adreste oluşturur ve ardından herkese aynı referenansı verir
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
            //Özetle ilgili arayüzleri implemente eden sınıflara otomatik olarak bir interceptor (ara katman) eklemeyi sağlar.
            //projenin yürütülen derlemesi (assembly) elde edilir.
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            //ilgili derlemedeki tüm sınıfların arayüzlerini uygulayıp uygulamadığı kontrol edilir. 
            // Ardından, AsImplementedInterfaces() metoduyla, ilgili sınıfların arayüzlerine bağımlı olarak kaydedilirler.
            //EnableInterfaceInterceptors(new ProxyGenerationOptions() { Selector = new AspectInterceptorSelector() }) metoduyla, bu sınıflara uygulanacak olan interceptor seçicisi belirlenir.
            //AspectInterceptorSelector, ilgili sınıfların üzerinde belirli işlemleri gerçekleştirmek için kullanılacak bir interceptor'ları seçmek için kullanılır.
            //Son olarak, SingleInstance() metoduyla, her bir sınıfın yalnızca bir kez oluşturulmasını sağlayan tek örnek (singleton) moduna geçilir.
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
