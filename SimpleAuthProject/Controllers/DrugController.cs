using Microsoft.AspNetCore.Mvc;
using pharmacyManagementWebApiservice.Models;
using pharmacyManagementWebApiservice.Dto;
using pharmacyManagementWebApiservice.Models;
using pharmacyManagementWebApiservice.Repository;
using System.Threading.Tasks;
using System;

namespace pharmacyManagementWebApiservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrugController : ControllerBase
    {
        private readonly IDrugRepository<DrugDetail> _drugRepository;

        public DrugController(IDrugRepository<DrugDetail> drugRepository)
        {
            _drugRepository = drugRepository;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var drug = await _drugRepository.GetAll();
                return Ok(drug);
            }
            catch (System.Exception)
            {

                return BadRequest();
            }
            

        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException();
                }
                var supplier = _drugRepository.GetDrug(id);
                if (supplier == null)
                {
                    throw new ArgumentException();
                }
                return new OkObjectResult(supplier);
            }
            catch (System.Exception)
            {

                return BadRequest();
            }
            
        }
        [HttpGet("Drugs/{drugName}")]
        public IActionResult GetDrugName(string drugName)
        {
            try
            {
                var drug = _drugRepository.GetDrugName(drugName);
                return new OkObjectResult(drug);
            }
            catch (Exception)
            {

                return BadRequest();
            }
            
        }
        [HttpPost]
        public IActionResult Post(DrugDto drugDto)
        {
            try
            {
                var drug = new DrugDetail
                {
                    DrugName = drugDto.DrugName,
                    Quantity = drugDto.Quantity,
                    Price = drugDto.Price,
                    ExpiryDate = drugDto.ExpiryDate,
                    SupplierId = drugDto.SupplierId,
                };
                var newSupplier = _drugRepository.Create(drug);
                return Created("Sucess", newSupplier);
            }
            catch (Exception)
            {
                return BadRequest();

            }
            

        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, DrugDto drugDto)
        {
            try
            {
                var drug = new DrugDetail
                {
                    DrugId = drugDto.DrugId,
                    DrugName = drugDto.DrugName,
                    Quantity = drugDto.Quantity,
                    ExpiryDate = drugDto.ExpiryDate,
                    Price = drugDto.Price,
                    SupplierId = drugDto.SupplierId,
                };

                _drugRepository.UpdateDrug(drug);
                return new OkResult();
            }
            catch (Exception)
            {

                return BadRequest();
            }
            

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _drugRepository.DeleteDrug(id);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
           
        }
    }
}
