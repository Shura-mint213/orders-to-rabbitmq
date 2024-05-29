using Microsoft.AspNetCore.Mvc;
using Shared.Interfaces;

namespace OrdersWebApp.Controllers
{
    [ApiController]
    [Route("Orders")]
    public class OrdersController : Controller
    {
        private readonly IRabbitMqService _rabbitMqService;
        public OrdersController(IRabbitMqService rabbitMqService) 
        {
            _rabbitMqService = rabbitMqService;
        }

        [HttpPost]
        [Route("Message/String")]
        public IActionResult MessageString(string msg)
        {
            _rabbitMqService.SendMessage(msg);
            return Ok();
        }
    }
}
