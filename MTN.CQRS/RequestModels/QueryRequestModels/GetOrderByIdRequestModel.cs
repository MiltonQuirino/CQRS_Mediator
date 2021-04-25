using System;
namespace MTN.CQRS.RequestModels.QueryRequestModels
{
    public class GetOrderByIdRequestModel
    {
        public Guid OrderId { get; set; }
    }
}
