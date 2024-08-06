using EmploymentVerification.Dto.Request;
using EmploymentVerification.Dto.ResponseMessage;

namespace EmploymentVerification.Business.IServices
{
    public interface IVerifyEmploymentService
    {
        ResponseMessageDto VerifyEmployment(EmploymentVerificationRequest employmentVerification);
    }
}
