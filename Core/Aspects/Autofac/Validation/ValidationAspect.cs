﻿using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new Exception("Bu bir doğrulama sınıfı değil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            //Gönderilen validator'u getirir.örn:ProductValidator'u getiriyor.Çalışma anında instance oluşturmak için activator.createinstance kullanılır.
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            //örn:productValidator'un BaseType'ı AbstractValidator generic arguments'i yani <Product> entityType Product'a denk gelir.
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            //metodun parametrelerine bak entity type denk olan,validator'un tipine eşit olan parametreleri bul örn:add metodunda Product product
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
