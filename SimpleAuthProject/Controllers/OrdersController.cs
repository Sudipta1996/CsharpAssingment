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
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersRepostiory _ordersRepository;

        public OrdersController(IOrdersRepostiory orderRepository)
        {
            _ordersRepository = orderRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var order = _ordersRepository.GetAll();
                return Ok(order);

            }
            catch (System.Exception)
            {

                return BadRequest();
            }
            
        }
        [HttpPost]
        public IActionResult Post(AddOrders addOrder)
        {
            try
            {
                var order = new Order
                {
                    OrderId = addOrder.OrderId,
                    UserId = addOrder.UserId,
                };
                var newOrder = _ordersRepository.Create(order);
                return Created("Sucess", newOrder);
            }
            catch (System.Exception)
            {

                return BadRequest();
            }
            

        }
        [HttpGet("{UserId}")]
        public IActionResult Get(int UserId)
        {
            try
            {
                if (UserId <= 0)
                {
                    throw new ArgumentException();
                }
                var orders = _ordersRepository.GetOrders(UserId);
                if (orders == null)
                {
                    throw new ArgumentException();
                }
                return new OkObjectResult(orders);
            }
            catch (System.Exception)
            {
                return BadRequest();

            }
           
        }
    }

}
