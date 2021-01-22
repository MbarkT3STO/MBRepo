using System.Data.Entity;
using System.Linq;

namespace MBRepo
{
    public class Repo<Tcontext>:IRepo<Tcontext> where Tcontext: DbContext, new()
    {
        private DbContext _Context { get; set; } = null;
        private DbSet    _Table   { get; set; } = null;


        public Repo()
        {
            _Context = new Tcontext();
        }
       

        public void GetAll<Table>() where Table:class, new()
        {
            _Table = new DbSet<Table>();

            return _Context.Set<Table>().ToList();
        }
    }
}