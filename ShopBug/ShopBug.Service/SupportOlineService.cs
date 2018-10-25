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
    public interface ISupportOlineService
    {
        void Add(SupportOnline supportOnline);
        void Update(SupportOnline supportOnline);
        void Delete(int id);
        IEnumerable<SupportOnline> GetAll();

    }
    public class SupportOlineService : ISupportOlineService
    {
        ISupportOnlineRepository _supportOnlineRepository;
        IUnitOfWork _unitOfWork;
        public SupportOlineService(ISupportOnlineRepository supportOnlineRepository, IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._supportOnlineRepository = supportOnlineRepository;

        }
        public void Add(SupportOnline supportOnline)
        {
            _supportOnlineRepository.Add(supportOnline);
        }

        public void Delete(int id)
        {
            _supportOnlineRepository.Delete(id);
        }

        public IEnumerable<SupportOnline> GetAll()
        {
            return _supportOnlineRepository.GetAll();
        }

        public void Update(SupportOnline supportOnline)
        {
            _unitOfWork.Commit();
        }
    }
}
