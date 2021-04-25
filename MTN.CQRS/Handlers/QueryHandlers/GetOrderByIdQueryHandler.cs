using MTN.CQRS.Interfaces.IQueryHandlers;
using MTN.CQRS.RequestModels.QueryRequestModels;
using MTN.CQRS.ResponseModels.QueryResponseModels;

namespace MTN.CQRS.Handlers.QueryHandlers
{
    public class GetOrderByIdQueryHandler : IGetOrderByIdQueryHandler
    {
        public GetOrderByIdResponseModel GetOrderById(GetOrderByIdRequestModel requestModel)
        {
            var result = new GetOrderByIdResponseModel();
            return result;
        }
    }
}
