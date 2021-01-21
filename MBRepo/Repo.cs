using System.Data.Entity;
using System.Linq;

namespace MBRepo
{
    public class Repo<Tcontext>:IRepo<Tcontext> where Tcontext: DbContext
    {
        private Tcontext _Context { get; set; } = null;
        private DbSet    _Table   { get; set; } = null;



       

        public void GetAll<Table>()
        {
            return _Context.Set<Table>().ToList();
        }
    }
}