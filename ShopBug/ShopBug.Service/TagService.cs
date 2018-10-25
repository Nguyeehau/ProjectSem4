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
    public interface ITagService
    {
        void Add(Tag tag);
        void Delete(int id);
        void Update(Tag tag);
        IEnumerable<Tag> GetAll();
        Tag GetById(int id);
    }
    public class TagService : ITagService
    {
        ITagRepository _tagRepository;
        IUnitOfWork _unitOfWork;
        public TagService(ITagRepository tagRepository, IUnitOfWork unitOfWork)
        {
            this._tagRepository = tagRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Tag tag)
        {
            _tagRepository.Add(tag);
        }

        public void Delete(int id)
        {
            _tagRepository.Delete(id);
        }

        public IEnumerable<Tag> GetAll()
        {
            return _tagRepository.GetAll();
        }

        public Tag GetById(int id)
        {
            return _tagRepository.GetSingleById(id);
        }

        public void Update(Tag tag)
        {
            _unitOfWork.Commit();
        }
    }
}
