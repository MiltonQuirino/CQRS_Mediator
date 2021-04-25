using System;
using MTN.CQRS.RequestModels.CommandRequestModels;
using MTN.CQRS.ResponseModels.CommandResponseModels;

namespace MTN.CQRS.Interfaces.ICommandHandlers
{
    public interface IMakeOrderCommandHandler
    {
        MakeOrderResponseModel MakeOrder(MakeOrderRequestModel requestModel);
    }
}
