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
    public interface IPostTagService
    {
        void Add(PostTag postTag);
        void Update(PostTag postTag);
        void Delete(int id);
        void SaveChanges();
        IEnumerable<PostTag> GetAll();
        PostTag GetById(int id);

    }
    public class PostTagService : IPostTagService
    {
        IPostTagRepository _postTagRepository;
        IUnitOfWork _unitOfWork;
        public PostTagService(IPostTagRepository postTagRepository, IUnitOfWork unitOfWork)
        {
            this._postTagRepository = postTagRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(PostTag postTag)
        {
            _postTagRepository.Add(postTag);
        }

        public void Delete(int id)
        {
            _postTagRepository.Delete(id);
        }

        public IEnumerable<PostTag> GetAll()
        {
            return _postTagRepository.GetAll();
        }

        public PostTag GetById(int id)
        {
            return _postTagRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostTag postTag)
        {
            _postTagRepository.Update(postTag);
        }
    }
}
