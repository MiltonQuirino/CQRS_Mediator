using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MTN.CQRS.Interfaces.ICommandHandlers;
using MTN.CQRS.RequestModels.CommandRequestModels;
using MTN.CQRS.ResponseModels.CommandResponseModels;

namespace MTN.CQRS.Handlers.CommandHandlers
{
    public class MakeOrderCommandHandler : IRequestHandler<MakeOrderRequestModel, MakeOrderResponseModel>
    {
     
        public async Task<MakeOrderResponseModel> Handle(MakeOrderRequestModel request, CancellationToken cancellationToken)
        {
            var result =  new MakeOrderResponseModel
            {
                IsSuccess = true,
                OrderId = Guid.NewGuid()
            };
            return result;
        }

      
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
