﻿using Microsoft.EntityFrameworkCore;
using pharmacyManagementWebApiservice.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pharmacyManagementWebApiservice.Repository
{
    public class DrugRepository : IDrugRepository<DrugDetail>
    {
        private readonly PharmacyManagementContext _context;

        //dependencyInjection//
        public DrugRepository(PharmacyManagementContext context)
        {
            _context = context;
        }
        public DrugDetail Create(DrugDetail drugDetail)
        {
            _context.DrugDetails.Add(drugDetail);//entity state//
            _context.SaveChanges();

            return drugDetail;
        }

        public void DeleteDrug(int id)
        {
            DrugDetail drug = GetDrug(id);
            _context.Remove(drug);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<DrugDetail>> GetAll()
        {
            return  await _context.DrugDetails.ToListAsync();
            /*.Include(order => order.OrderDetails).ToList()*/;

            //return _context.SupplierDetails.Include(drug => drug.DrugDetails).ToList();
        }
        public DrugDetail GetDrug(int id)
        {
            //return _context.DrugDetails.FirstOrDefault(u => u.DrugId == id);
            var drug = _context.DrugDetails.Where(u => u.DrugId == id).Include(c => c.OrderDetails).FirstOrDefault();
            return drug;
        }
        public DrugDetail GetDrugName(string drugName)
        {
            //return _context.DrugDetails.FirstOrDefault(u => u.DrugId == id);
            //var drug = _context.DrugDetails.Where(u => u.DrugName == drugName).Include(c => c.OrderDetails).FirstOrDefault();
            //return drug;
            return _context.DrugDetails.FirstOrDefault(x => x.DrugName == drugName);
        }

        public void UpdateDrug(DrugDetail drugDetail)
        {
            _context.Entry(drugDetail).State = EntityState.Modified;
            _context.SaveChanges();
        }

       
    }
}
