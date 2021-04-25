using System;
using Microsoft.AspNetCore.Mvc;
using MTN.CQRS.Interfaces.ICommandHandlers;
using MTN.CQRS.Interfaces.IQueryHandlers;
using MTN.CQRS.RequestModels.CommandRequestModels;
using MTN.CQRS.RequestModels.QueryRequestModels;

namespace MTN.CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController:ControllerBase
    {
        private readonly IGetOrderByIdQueryHandler _getOrderByIdQueryHandler;
        private readonly IMakeOrderCommandHandler _makeOrderCommandHandler;

        public OrderController(IGetOrderByIdQueryHandler getOrderByIdQueryHandler,
            IMakeOrderCommandHandler makeOrderCommandHandler)
        {
            _getOrderByIdQueryHandler = getOrderByIdQueryHandler;
            _makeOrderCommandHandler = makeOrderCommandHandler;
        }

        [HttpPost("makeorder")]
        public IActionResult MakeOrder([FromBody] MakeOrderRequestModel requestModel)
        {
            var response = _makeOrderCommandHandler.MakeOrder(requestModel);
            //var response = _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("order")]
        public IActionResult OrderDetails([FromQuery] GetOrderByIdRequestModel requestModel)
        {
            var response = _getOrderByIdQueryHandler.GetOrderById(requestModel);
            //var response = _mediator.Send(requestModel);
            return Ok(response);
        }


    }
}
