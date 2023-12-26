using Microsoft.EntityFrameworkCore;
using NTierECommerce.BLL.Abstracts;
using NTierECommerce.DAL.Context;
using NTierECommerce.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.BLL.Concretes
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly EcommerceContext _context;
        private DbSet<T> _entites;
        public BaseRepository(EcommerceContext context)
        {
            _context = context;
            _entites = _context.Set<T>();
        }

        public async Task<string> Create(T entity)
        {
            //_context.Set<T>().Add(entity);
            try
            {
              await  _context.AddAsync(entity);
              await  _context.SaveChangesAsync();
                return "kayıt başarılı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public async Task<string> Delete(T entity)
        {
            try
            {
               // _context.Remove(entity);
               entity.Status = Entities.Enums.DataStatus.Deleted;
               await _context.SaveChangesAsync();
                return "silme işlemi başarılı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> DestroyData(T entity)
        {
            try
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync();
                return "silme işlemi başarılı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<T> GetAll()
        {
            var result = _context.Set<T>().ToList();
            return result;
        }

        public IEnumerable<T> GetAllActive()
        {
            var result = _context.Set<T>().Where(x => x.IsActive == true).ToList();
            return result;
        }

        public IEnumerable<T> GetAllPassive()
        {
            var result = _context.Set<T>().Where(x => x.IsActive == false).ToList();
            return result;
        }

        public async Task<T> GetById(int id)
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(x=>x.Id==id);
            return  result;
        }

        public async Task<string> Update(T entity)
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == entity.Id);
            try
            {
                //_context.Remove(result);
                // await _context.AddAsync(entity);
                _context.Entry(result).CurrentValues.SetValues(entity);
                //_context.Entry(entity).State = EntityState.Modified;

               await _context.SaveChangesAsync();
                return "güncelleme başarılı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
