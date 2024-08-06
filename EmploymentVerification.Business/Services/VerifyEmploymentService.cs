using EmploymentVerification.Business.IServices;
using EmploymentVerification.Data.CoreServices;
using EmploymentVerification.Data.ICoreServices;
using EmploymentVerification.Dto.Request;
using EmploymentVerification.Dto.ResponseMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentVerification.Business.Services
{
    public class VerifyEmploymentService : IVerifyEmploymentService
    {
        private readonly ICoreVerifyEmploymentService _coreVerifyEmploymentService;

        public VerifyEmploymentService(ICoreVerifyEmploymentService coreVerifyEmploymentService)
        {
            _coreVerifyEmploymentService = coreVerifyEmploymentService;
        }
        public ResponseMessageDto VerifyEmployment(EmploymentVerificationRequest employmentVerification)
        {
            return _coreVerifyEmploymentService.VerifyEmployment(employmentVerification);
        }
    }
}
