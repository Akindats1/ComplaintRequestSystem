﻿using ComplaintRequestSystem.Models;
using ComplaintRequestSystem.Models.Request;

namespace ComplaintRequestSystem.Service.Interfaces
{
    public interface IRequestService
    {
        BaseResponseModel CreateRequest(CreateRequestViewModel request);
        BaseResponseModel DeleteRequest(string requestId);
        BaseResponseModel UpdateRequest(string requestId, UpdateRequestViewModel request);
        RequestResponseModel GetRequest(string requestId);
        RequestsResponseModel GetAllRequest();
    }
}
