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
    public interface ISlideService
    {
        void Add(Slide slide);
        void Delete(int id);
        void Update(Slide slide);
        void SaveChanges();
        IEnumerable<Slide> GetAll();
        Slide GetById(int id);

    }
    public class SlideService : ISlideService
    {
        ISlideRepository _slideRepository;
        IUnitOfWork _unitOfWork;
        public SlideService(ISlideRepository slideRepository, IUnitOfWork unitOfWork)
        {
            this._slideRepository = slideRepository;
            this._unitOfWork = unitOfWork;

        }
        public void Add(Slide slide)
        {
            _slideRepository.Add(slide);
        }

        public void Delete(int id)
        {
            _slideRepository.Delete(id);
        }

        public IEnumerable<Slide> GetAll()
        {
            return _slideRepository.GetAll();
        }

        public Slide GetById(int id)
        {
            return _slideRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Slide slide)
        {
            _slideRepository.Update(slide);
        }
    }
}
