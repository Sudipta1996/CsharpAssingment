using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pharmacyManagementWebApiservice.Models;
using pharmacyManagementWebApiservice.Dto;
using pharmacyManagementWebApiservice.Models;
using pharmacyManagementWebApiservice.Repository;
using System;

namespace pharmacyManagementWebApiservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var order = _orderRepository.GetAll();
                return Ok(order);
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
                var supplier = _orderRepository.GetOrder(id);
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
        [HttpPost]
        public IActionResult Post(OrderDto orderDto)
        {
            try
            {
                var order = new OrderDetail
                {
                    DrugId = orderDto.DrugId,
                    Quantity = orderDto.Quantity,
                    TotalAmount = orderDto.TotalAmount,
                    OrderPrice = orderDto.OrderPrice,
                };
                var newOrder = _orderRepository.Create(order);
                return Created("Sucess", newOrder);
            }
            catch (Exception)
            {

                return BadRequest();
            }
            

        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, OrderDto orderDto)
        {
            try
            {
                var order = new OrderDetail
                {
                    DrugId = orderDto.DrugId,
                    Quantity = orderDto.Quantity,
                    TotalAmount = orderDto.TotalAmount,
                    OrderPrice = orderDto.OrderPrice,
                };
                _orderRepository.UpdateOrder(order);
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
                _orderRepository.DeleteOrder(id);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
            
        }

    }
}
