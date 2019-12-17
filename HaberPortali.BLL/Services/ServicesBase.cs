using HaberPortali.BLL.IServices.IBaseServices;
using HaberPortali.Core.DataAccess.IBaseRepository;
using HaberPortali.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.BLL.Services
{
    public class ServicesBase<TEntity, TKey> : IService<TEntity, TKey> where TEntity : class, IEntity, new()
    {
        IRepository<TEntity, TKey> _repository;
        public ServicesBase(IRepository<TEntity, TKey> repository)
        {
            _repository = repository;

        }

        public string Ekle(TEntity entity)
        {
            try
            {
                _repository.Add(entity);
                return "Kayıt işlemi başarılı ile tamamlanmıştır.";
            }
            catch (Exception)
            {
                return "Bir hata oluştu kayıt yapılırken";
            }

        }

        public List<TEntity> Getir(Expression<Func<TEntity, bool>> exp = null)
        {
            return _repository.Get(exp);
        }

        public TEntity Getir(TKey id)
        {
            return _repository.GetById(id);
        }

        public string Guncelle(TEntity entity)
        {
            try
            {
                _repository.Update(entity);
                return "Güncellendi";
            }
            catch (Exception e)
            {
                return "Güncellenmedi hata:" + e.Message;
            }
        }

        public string Sil(TEntity entity)
        {
            try
            {
                _repository.Delete(entity);
                return "Silindi";
            }
            catch (Exception e)
            {
                return "Silinmede başarısız hata:" + e.Message;
            }
        }
    }
}
