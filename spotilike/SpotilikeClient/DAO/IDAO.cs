using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotilikeClient.DAO
{
    interface IDAO<T>
    {
        T findById(int id);

        List<T> findAll();

        void delete(int id);

        T update(int id, T o);

        T create(T o);
    }
}
