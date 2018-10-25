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
    public interface IProductTagService
    {
        void Add(ProductTag productTag);
        void Delete(int id);
        void Update(ProductTag productTag);
        IEnumerable<ProductTag> GetAll();
        ProductTag GetById(int id);
        void SaveChanges();
    }
    public class ProductTagService : IProductTagService
    {
        IProductTagRepository _productTagRepository;
        IUnitOfWork _unitOfWork;
        public ProductTagService(IProductTagRepository productTagRepository, IUnitOfWork unitOfWork)
        {
            this._productTagRepository = productTagRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(ProductTag productTag)
        {
            _productTagRepository.Add(productTag);
        }

        public void Delete(int id)
        {
            _productTagRepository.Delete(id);
        }

        public IEnumerable<ProductTag> GetAll()
        {
            return _productTagRepository.GetAll();
        }

        public ProductTag GetById(int id)
        {
            return _productTagRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductTag productTag)
        {
            _productTagRepository.Update(productTag);
        }
    }
}
