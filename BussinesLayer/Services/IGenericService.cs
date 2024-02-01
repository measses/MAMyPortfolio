using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Services;

public interface IGenericService<T>
{
    void TAdd(T t);
    void TRemove(T t);
    List<T> TGetAll();
    void TUpdate(T t);
    T TGetById(int id);

   
}
