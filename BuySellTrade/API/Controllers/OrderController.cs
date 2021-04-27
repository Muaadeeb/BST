using DataLibrary.Data;
using DataLibrary.Data.Interfaces;
using DataLibrary.Db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderData _orderData;
        private readonly IFoodData _foodData;

        public OrderController(IOrderData orderData, IFoodData foodData)
        {
            _orderData = orderData;
            _foodData = foodData;
        }


        // start at 18:00

        [HttpPost]
        [ValidateModel]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(OrderModel order)
        {
            // validate sp_ordersInsert is there.
            var food = await _foodData.GetFood();

            order.Total = order.Quantity * food.Where(x => x.FoodId == order.FoodId).First().Price;
            int orderId = await _orderData.CreateOrder(order);

            return Ok(orderId);
        }
        
    }
}
