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
    public interface IVisitorStatisticService
    {
        void Add(VisitorStatistic visitorStatistic);
        void Delete(int id);
        void Update(VisitorStatistic visitorStatistic);
        IEnumerable<VisitorStatistic> GetAll();
        void SaveChanges();

    }
    public class VisitorStatisticService : IVisitorStatisticService
    {
        IVisitorStatisticRepository _visitorStatisticRepository;
        IUnitOfWork _unitOfWork;
        public VisitorStatisticService(IVisitorStatisticRepository visitorStatisticRepository, IUnitOfWork unitOfWork)
        {
            this._visitorStatisticRepository = visitorStatisticRepository;
            this._unitOfWork = unitOfWork;
        }


        public void Add(VisitorStatistic visitorStatistic)
        {
            _visitorStatisticRepository.Add(visitorStatistic);
        }

        public void Delete(int id)
        {
            _visitorStatisticRepository.Delete(id);
        }

        public IEnumerable<VisitorStatistic> GetAll()
        {
            return _visitorStatisticRepository.GetAll();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(VisitorStatistic visitorStatistic)
        {
            _visitorStatisticRepository.Update(visitorStatistic);
        }
    }
}
