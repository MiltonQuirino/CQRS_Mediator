using System;
using MediatR;
using MTN.CQRS.ResponseModels.QueryResponseModels;

namespace MTN.CQRS.RequestModels.QueryRequestModels
{
    public class GetOrderByIdRequestModel:IRequest<GetOrderByIdResponseModel>
    {
        public Guid OrderId { get; set; }
    }
}
