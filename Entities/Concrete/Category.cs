using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    /// <summary>
    /// çıplak class kalmasın:eğer herhangi bir class herhangi bir inheritance vs almıyorsa problem var demektir.
    /// </summary>
   public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
