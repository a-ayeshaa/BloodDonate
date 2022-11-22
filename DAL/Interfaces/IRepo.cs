using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS,ID,RETURN>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        RETURN Add(CLASS obj);
        bool Update(CLASS obj);
        bool Delete(ID id);

    }
}
