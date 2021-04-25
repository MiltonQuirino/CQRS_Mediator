using MTN.CQRS.RequestModels.QueryRequestModels;
using MTN.CQRS.ResponseModels.QueryResponseModels;

namespace MTN.CQRS.Interfaces.IQueryHandlers
{
    public interface IGetOrderByIdQueryHandler
    {
        GetOrderByIdResponseModel GetOrderById(GetOrderByIdRequestModel requestModel);
    }
}
