﻿using ComplaintRequestSystem.Models;
using ComplaintRequestSystem.Models.Complaint;

namespace ComplaintRequestSystem.Service.Interfaces
{
    public interface IComplaintService
    {
        BaseResponseModel CreateComplaint(CreateComplaintViewModel request);
        BaseResponseModel DeleteComplaint(string complaintId);
        BaseResponseModel UpdateComplaint(string complaintId, UpdateComplaintViewModel request);
        ComplaintResponseModel GetComplaint(string complaintId);
        ComplaintsResponseModel GetAllComplaint();
    }
}
