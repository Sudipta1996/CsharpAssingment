using Microsoft.EntityFrameworkCore;
using pharmacyManagementWebApiservice.Models;
using System.Collections.Generic;
using System.Linq;

namespace pharmacyManagementWebApiservice.Repository
{
    public class SupplierRepository : ISuplierRepository
    {
        private readonly PharmacyManagementContext _context;

        public SupplierRepository(PharmacyManagementContext context)//Constructor Dependency Injection//
        {
            _context = context;
        }
        #region Create
        public SupplierDetail  Create(SupplierDetail supplierDetail)
        {
            _context.SupplierDetails.Add(supplierDetail);
            _context.SaveChanges();

            return supplierDetail;
        }
        #endregion
        #region DeleteSupplier
        public void DeleteSupplier(int id)
        {
            SupplierDetail supplier = GetSupplier(id);
            _context.Remove(supplier);
            _context.SaveChanges();
        }
        #endregion
        public IEnumerable<SupplierDetail> GetAll()//get all details//
        {
            return _context.SupplierDetails.Include(drug => drug.DrugDetails).ToList();
        }
        public SupplierDetail GetSupplier(int id)//get supplier by id//
        {
            var supplier =  _context.SupplierDetails.Where(u => u.SupplierId == id).Include(c => c.DrugDetails).FirstOrDefault();
            return supplier;
            
            //var supplier = _context.SupplierDetails.Where(u => u.SupplierId == id).Include(c => c.DrugDetails).ToList();
            //return supplier;
        }
        //var products = await _context.Products.Where(p => p.UserId == userId).Include(c => c.Orders)
        //        .ToListAsync();
        //    return products;
        public void UpdateSupplier(SupplierDetail supplierDetail)//update supplier//
        {
            _context.Entry(supplierDetail).State = EntityState.Modified;
            _context.SaveChanges();

        }
    }
}
