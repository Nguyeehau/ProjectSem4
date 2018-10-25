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
    public interface ISystemConfigService
    {
        void Add(SystemConfig systemConfig);
        void Delete(int id);
        void Update(SystemConfig systemConfig);
        IEnumerable<SystemConfig> GetAll();
        void SaveChanges();
    }
    public class SystemConfigService : ISystemConfigService
    {
        ISystemConfigRepository _systemConfigRepository;
        IUnitOfWork _unitOfWork;
        public SystemConfigService(ISystemConfigRepository systemConfigRepository, IUnitOfWork unitOfWork)
        {
            this._systemConfigRepository = systemConfigRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(SystemConfig systemConfig)
        {
            _systemConfigRepository.Add(systemConfig);

        }

        public void Delete(int id)
        {
            _systemConfigRepository.Delete(id);

        }

        public IEnumerable<SystemConfig> GetAll()
        {
            return _systemConfigRepository.GetAll();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(SystemConfig systemConfig)
        {
        }
    }
}
