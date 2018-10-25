using ShopBug.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBug.Service
{
    public interface IMenuService
    {
        void Add(Menu menu);
        void Delete(int id);
        void Update(Menu menu);
        IEnumerable<Menu> GetAll();
        Menu GetById(int id);
        void SaveChanges();

    }
    public class MenuService : IMenuService
    {
        public void Add(Menu menu)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Menu> GetAll()
        {
            throw new NotImplementedException();
        }

        public Menu GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Menu menu)
        {
            throw new NotImplementedException();
        }
    }
}
