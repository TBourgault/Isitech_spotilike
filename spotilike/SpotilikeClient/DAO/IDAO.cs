using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotilikeClient.DAO
{
    interface IDAO<T>
    {
        List<T> findAll();

        T findById(int id);
    }
}
