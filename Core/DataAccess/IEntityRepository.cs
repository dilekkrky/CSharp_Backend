using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint =generic kısıt demekk ,class:referans tip olabilir demek
    //IEntity:IEntity olabilir veya IEntity implemente eden bir nesne olabilir demek
    //new() :new'lenebilir olmalı ıentity newlenemez ve biz buraya ıentity gönderemeyiz
    public interface IEntityRepository<T> where T:class,IEntity,new()
    { ///filter=null filtre olmayadabilir demektir.Alt satır bizim filtrelerme yapmamızı sağlar.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter); 
        void Add(T entity); 
        void Update(T entity);
        void Delete(T entity);
    }
}
