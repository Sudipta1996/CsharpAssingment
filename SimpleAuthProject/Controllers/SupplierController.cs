using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pharmacyManagementWebApiservice.Models;
using pharmacyManagementWebApiservice.Repository;
using pharmacyManagementWebApiservice.Dto;
using pharmacyManagementWebApiservice.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace pharmacyManagementWebApiservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISuplierRepository _suplierRepository;
        public SupplierController(ISuplierRepository suplierRepository)
        {
            _suplierRepository = suplierRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
           
            try
            {
                var supplier = _suplierRepository.GetAll();
                return Ok(supplier);
            }
            catch (Exception)
            {

                return BadRequest();
            }
            
            


        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                if(id <= 0)
                {
                    throw new ArgumentException();
                }
                var supplier = _suplierRepository.GetSupplier(id);
                if (supplier == null)
                {
                    throw new ArgumentException();
                }
                return new OkObjectResult(supplier);
            }
            catch (Exception)
            {

                return BadRequest();
            }
            
        }
        [HttpPost]
        public IActionResult Post(CreateSupplierDto createSupplier)
        {
            try
            {
                var supplier = new SupplierDetail
                {
                    SupplierName = createSupplier.SupplierName,
                    SupplierContact = createSupplier.SupplierContact,
                    SupplierEmail = createSupplier.SupplierEmail,
                };
                var newSupplier = _suplierRepository.Create(supplier);
                return Created("Sucess", newSupplier);
            }
            catch (Exception)
            {

                return BadRequest();
            }
            

        }
        #region supplierUpdate      
        [HttpPut("{id}")]
        public IActionResult Put(int id, CreateSupplierDto createSupplier)
        {
            try
            {
                var supplier = new SupplierDetail
                {
                    SupplierId = createSupplier.SupplierId,
                    SupplierName = createSupplier.SupplierName,
                    SupplierContact = createSupplier.SupplierContact,
                    SupplierEmail = createSupplier.SupplierEmail,
                };
                _suplierRepository.UpdateSupplier(supplier);
                return new OkResult();
            }
            catch (Exception)
            {

                 return  BadRequest();
            }
        }
        #endregion supplier
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _suplierRepository.DeleteSupplier(id);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

    }
}
