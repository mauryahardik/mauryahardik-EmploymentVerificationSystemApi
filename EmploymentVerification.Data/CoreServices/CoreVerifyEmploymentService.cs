using EmploymentVerification.Data.Common;
using EmploymentVerification.Data.ICoreServices;
using EmploymentVerification.Dto.Request;
using EmploymentVerification.Dto.Response;
using EmploymentVerification.Dto.ResponseMessage;

namespace EmploymentVerification.Data.CoreServices
{
    public class CoreVerifyEmploymentService : ICoreVerifyEmploymentService
    {
        private readonly List<Employees> _employees;
        public CoreVerifyEmploymentService()
        {
            _employees = new List<Employees>
        {
            new Employees { EmployeeId = 1, CompanyName = "TCS", VerificationCode = "ABC123" },
            new Employees { EmployeeId = 2, CompanyName = "Wipro", VerificationCode = "XYZ456" },
            new Employees { EmployeeId = 2, CompanyName = "Accenture", VerificationCode = "54456" },
        };
        }
        public ResponseMessageDto VerifyEmployment(EmploymentVerificationRequest employmentVerification)
        {
            bool isEmployeeExists = _employees.Any(e => e.EmployeeId == employmentVerification.EmployeeId);
            if (isEmployeeExists)
            {
                bool isVerifiedEmployee = _employees.Any(e =>
               e.EmployeeId == employmentVerification.EmployeeId &&
               e.CompanyName.Equals(employmentVerification.CompanyName, StringComparison.OrdinalIgnoreCase) &&
               e.VerificationCode == employmentVerification.VerificationCode
           );
                if (isVerifiedEmployee)
                {
                    return new ResponseMessageDto
                    {
                        Data = isVerifiedEmployee,
                        IsSuccess = true,
                        Message = Constants.EmployeeVerificationSuccess
                    };
                }
                else
                {
                    return new ResponseMessageDto
                    {
                        Data = isVerifiedEmployee,
                        IsSuccess = true,
                        Message = Constants.EmployeeVerificationNotSuccess
                    };
                }
            }
            else
            {
                return new ResponseMessageDto
                {
                    Data = isEmployeeExists,
                    IsSuccess = true,
                    Message = Constants.EmployeeNotFound
                };
            }
        }
    }
}
