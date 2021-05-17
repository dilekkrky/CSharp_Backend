using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        ////public ile bu classa diğer katmanlar da ulaşabilsin diye ekledik
        ////bir classın defaultu internal dır.
        
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public short  UnitsInStock { get; set; }

        public decimal UnitPrice { get; set; }


    }
}
