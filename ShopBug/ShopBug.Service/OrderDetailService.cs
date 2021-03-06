﻿using ShopBug.Data.Infrastructure;
using ShopBug.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Repositories;

namespace ShopBug.Service
{
    public interface IOrderDetailService
    {
        void Add(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        void Delete(int id);
        void SaveChanges();
        IEnumerable<OrderDetail> GetAll();
        OrderDetail GetById(int id);
    }
    public class OrderDetailService : IOrderDetailService
    {

        IOrderDetailRepository _orderDetailRepository;
        IUnitOfWork _unitOfWork;
        public OrderDetailService(IOrderDetailRepository orderDetailRepository, IUnitOfWork unitOfWork)
        {
            this._orderDetailRepository = orderDetailRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(OrderDetail orderDetail)
        {
            _orderDetailRepository.Add(orderDetail);
        }

        public void Delete(int id)
        {
            _orderDetailRepository.Delete(id);
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return _orderDetailRepository.GetAll();
        }

        public OrderDetail GetById(int id)
        {
            return _orderDetailRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(OrderDetail orderDetail)
        {
            _orderDetailRepository.Update(orderDetail);
        }
    }
}
