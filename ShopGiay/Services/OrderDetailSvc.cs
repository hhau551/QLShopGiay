﻿using ShopGiay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopGiay.Services
{
    public interface IOrderDetailSvc
    {
        List<OrderDetails> GetOrderDetails(int id);

        int AddOrderDetail(OrderDetails orderDetails);
    }
    public class OrderDetailSvc : IOrderDetailSvc
    {
        protected DataContext _context;
        public OrderDetailSvc(DataContext context)
        {
            _context = context;
        }
        public List<OrderDetails> GetOrderDetails(int id)
        {
            List<OrderDetails> list = _context.OrderDetails.Where(x => x.OrderID == id ).ToList();
            return list;
        }
        public int AddOrderDetail(OrderDetails orderDetails)
        {
            int ret = 0;
            try
            {
                _context.Add(orderDetails);
                _context.SaveChanges();
                ret = orderDetails.OrderID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
    }
}
