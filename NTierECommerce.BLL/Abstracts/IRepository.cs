using NTierECommerce.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.BLL.Abstracts
{
    public interface IRepository<T>where T : BaseEntity
    {
        //List 
        IEnumerable<T> GetAll();//IEnumerable bir koleksiyon içersinde farklı bir koleksiyonu teslim alır ve içerde kalan koleksiyonun değerlerini döngüye ihtiyac duymadan teslim eder.

        //List Active
        IEnumerable<T> GetAllActive();
        //List Passive
        IEnumerable<T> GetAllPassive();
        //Destroy
        Task<string> DestroyData (T entity);
        //Create   asyc tanımlamamız gerekiyor 
        Task<string> Create(T entity);
        //Read
        Task<T> GetById (int id);
        //Update
        Task<string> Update (T entity);
        //Delete
        Task<string> Delete(T entity);
    }
}
