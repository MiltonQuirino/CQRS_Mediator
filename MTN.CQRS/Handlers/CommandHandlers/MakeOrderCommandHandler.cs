using System;
using MTN.CQRS.Interfaces.ICommandHandlers;
using MTN.CQRS.RequestModels.CommandRequestModels;
using MTN.CQRS.ResponseModels.CommandResponseModels;

namespace MTN.CQRS.Handlers.CommandHandlers
{
    public class MakeOrderCommandHandler : IMakeOrderCommandHandler
    {
        public MakeOrderResponseModel MakeOrder(MakeOrderRequestModel requestModel)
        {
            var result = new MakeOrderResponseModel
            {
                IsSuccess = true,
                OrderId = Guid.NewGuid()
            };
            return result;
        }
    }
}
