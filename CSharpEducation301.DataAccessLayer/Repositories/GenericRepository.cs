using CSharpEducation301.DataAccessLayer.Abstract;
using CSharpEducation301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class

    {
        CampContext context = new CampContext();
        private readonly DbSet<T> _object; //field

        public GenericRepository()
        {
            _object = context.Set<T>(); // context sınıfından admin, product, category gibi sınıfların set edilmesi
        }

        public void Delete(T entity)
        {
            var deletedEntity = context.Entry(entity); // entity'i hafızaya al
            deletedEntity.State = EntityState.Deleted; // enum ile silme işlemi
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added; // enum ile ekleme işlemi
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified; // enum ile güncelleme işlemi
            context.SaveChanges();
        }
    }
}
