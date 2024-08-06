using EmploymentVerification.Dto.Request;
using EmploymentVerification.Dto.ResponseMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentVerification.Data.ICoreServices
{
    public interface ICoreVerifyEmploymentService
    {
        ResponseMessageDto VerifyEmployment(EmploymentVerificationRequest employmentVerification);
    }
}
