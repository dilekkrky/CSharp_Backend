using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidaiton
{
    public class ProductValidator : AbstractValidator<Product>
    { /// <summary>
      /// hangi nesne için validator yazılcaksa buraya.dto lar için de gecerlidir.
      /// </summary>
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            //olmayan bir kuralı nasıl yazarım
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler a harfi ile başlamalı");

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
