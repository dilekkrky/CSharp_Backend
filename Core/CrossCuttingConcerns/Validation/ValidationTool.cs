using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);
           //Ivalidator: ProductValidator productValidator = new ProductValidator();
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                //sonuc geccerli değilse hata fırlat
                throw new ValidationException(result.Errors);
            }
        }
    }
}
