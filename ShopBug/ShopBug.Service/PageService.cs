using ShopBug.Data.Infrastructure;
using ShopBug.Data.Repositories;
using ShopBug.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBug.Service
{
    public interface IPageService
    {
        void Add(Page page);
        void Update(Page page);
        void Delete(int id);
        void SaveChangese();
        IEnumerable<Page> GetAll();
        Page GetById(int id);
    }
    public class PageService : IPageService
    {
        IPageRepository _pageRepository;
        IUnitOfWork _unitOfWork;
        public PageService(IPageRepository pageRepository, IUnitOfWork unitOfWork)
        {
            this._pageRepository = pageRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Page page)
        {
            _pageRepository.Add(page);
        }

        public void Delete(int id)
        {
            _pageRepository.Delete(id);
        }

        public IEnumerable<Page> GetAll()
        {
            return _pageRepository.GetAll();
        }

        public Page GetById(int id)
        {
            return _pageRepository.GetSingleById(id);
        }

        public void SaveChangese()
        {
            _unitOfWork.Commit();
        }

        public void Update(Page page)
        {
            _pageRepository.Update(page);
        }
    }
}
