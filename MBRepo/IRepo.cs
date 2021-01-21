using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBRepo
{
    interface IRepo<Tcontext> where  Tcontext : DbContext
    {
        void GetAll<Table>();
        void GetOne<Table>(object pkValue);

    }
}
