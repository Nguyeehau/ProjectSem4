using ShopBug.Data.Infrastructure;
using ShopBug.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Repositories;

namespace ShopBug.Service
{
    public interface IFooterService
    {
        void Add(Footer footer);
        void Delete(int id);
        void Update(Footer footer);
        IEnumerable<Footer> GetAll();
        Footer GetById(int id);
        void SaveChanges();
    }
    public class FooterService : IFooterService
    {
        IFooterRepository _footerRepository;
        IUnitOfWork _unitOfWork;
        public FooterService(IFooterRepository footerRepository, IUnitOfWork unitOfWork)
        {
            this._footerRepository = footerRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Footer footer)
        {
            _footerRepository.Add(footer);
        }

        public void Delete(int id)
        {
            _footerRepository.Delete(id);
        }

        public IEnumerable<Footer> GetAll()
        {
            return _footerRepository.GetAll();
        }

        public Footer GetById(int id)
        {
            return _footerRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Footer footer)
        {
            _footerRepository.Update(footer);
        }
    }
}
