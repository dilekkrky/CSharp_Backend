using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        /// <summary>
        /// interface methodları default publictir add,delete,update
        /// </summary>
        /// <returns></returns>
        //////////veritabanında yapacağım operasyonları içerecek
        List<ProductDetailDto> GetProductDetails();
    }
}
