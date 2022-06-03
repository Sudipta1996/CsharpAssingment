﻿using pharmacyManagementWebApiservice.Models;
using System.Collections.Generic;

namespace pharmacyManagementWebApiservice.Repository
{
    public interface ISuplierRepository
    {
        SupplierDetail Create(SupplierDetail supplierDetail);
        IEnumerable<SupplierDetail> GetAll();

        SupplierDetail GetSupplier(int id);
        void DeleteSupplier(int id);
        void UpdateSupplier(SupplierDetail supplierDetail);
    }
}
