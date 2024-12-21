using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation301.BusinessLayer.Abstract
{

    public interface IGenericService<T> where T : class
    {
        // Ara köprü görevi gören katmandan çağırıcaz bu yüzedn T kullandık.
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);
        List<T> TGetAll();
        T TGetById(int id);

    }
}
