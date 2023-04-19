﻿using Castle.DynamicProxy;
using Core.Aspects.Autofac.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Interceptors
{

    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            List<MethodInterceptionBaseAttribute> classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);
            //Tüm sisteme loglamayı ekliyor
            //classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger)));
            //tüm projeye transaction ekler
            classAttributes.Add(new TransactionScopeAspect());
            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}
