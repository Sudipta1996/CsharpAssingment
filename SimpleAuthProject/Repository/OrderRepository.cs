using Microsoft.EntityFrameworkCore;
using pharmacyManagementWebApiservice.Models;
using System.Collections.Generic;
using System.Linq;

namespace pharmacyManagementWebApiservice.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly PharmacyManagementContext _context;
        public OrderRepository(PharmacyManagementContext context)//Constructor dependency inject//
        {
            _context = context;
        }
        #region Orderdetail
        public OrderDetail Create(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();

            return orderDetail;
        }
        #endregion
        #region DeleteOrder
        public void DeleteOrder(int id)
        {
            OrderDetail drugs  = GetOrder(id);
            _context.Remove(drugs);
            _context.SaveChanges();


        }
        #endregion
        public IEnumerable<OrderDetail> GetAll()//Get all Order//
        {
            return _context.OrderDetails.Include(ordr => ordr.Drug).ToList();
                //return _context.SupplierDetails.Include(drug => drug.DrugDetails).ToList();
        }


        public OrderDetail GetOrder(int id)//Get Orderdetail by id//
        {
            var supplier = _context.OrderDetails.Where(u => u.OrderId == id).Include(c => c.Drug).FirstOrDefault();
            return supplier;
        }

        public void UpdateOrder(OrderDetail orderDetail)//Update Order//
        {
            _context.Entry(orderDetail).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
