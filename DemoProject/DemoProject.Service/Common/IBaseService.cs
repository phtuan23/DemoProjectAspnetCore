using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Service.Common
{
    public interface IBaseService<T>
    {
        public List<T> GetList();
        public T GetById(string id);

        public T Create(T entity);

        public T Update(T entity);

        public void Delete(string id);
    }
}
