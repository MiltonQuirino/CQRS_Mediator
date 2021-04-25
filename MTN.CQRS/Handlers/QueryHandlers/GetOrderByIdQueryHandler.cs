using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MTN.CQRS.Interfaces.IQueryHandlers;
using MTN.CQRS.RequestModels.QueryRequestModels;
using MTN.CQRS.ResponseModels.QueryResponseModels;

namespace MTN.CQRS.Handlers.QueryHandlers
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdRequestModel,GetOrderByIdResponseModel>
    {
        // without Mediator
        public GetOrderByIdResponseModel GetOrderById(GetOrderByIdRequestModel requestModel)
        {
            var result = new GetOrderByIdResponseModel();
            return result;
        }

        // With Mediator
        public async Task<GetOrderByIdResponseModel> Handle(GetOrderByIdRequestModel request,
            CancellationToken cancellationToken)
        {
            var result = new GetOrderByIdResponseModel();
            return result;
        }
    }
}
