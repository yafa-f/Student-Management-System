using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalAPI
{
    public interface Icrud<T>
    {
        public void Create(T item);
        public void Update(T item);
        public void Delete(T item);
        public List<T> Read();
    }
}
