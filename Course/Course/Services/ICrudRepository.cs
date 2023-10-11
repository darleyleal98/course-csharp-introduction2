using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Services
{
    public interface ICrudRepository<T, ID>
    {
        public T Save(T obj);
        public void Delete(T obj);
        public T FindById(ID id);
        public List<T> FindAll();
    }
}
