using EmploymentVerification.Business.IServices;
using EmploymentVerification.Dto.Request;
using EmploymentVerification.Dto.ResponseMessage;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentVerificationSystem.Controllers
{
    [Route("api")]
    [ApiController]
    [EnableCors("CustomCorsPolicy")]
    public class VerifyEmploymentController : ControllerBase
    {
        private readonly IVerifyEmploymentService _verifyEmploymentService;

        public VerifyEmploymentController(IVerifyEmploymentService verifyEmploymentService)
        {
            _verifyEmploymentService = verifyEmploymentService;
        }

        [HttpPost]
        [Route("verify-employment")]
        public IActionResult VerifyEmployment([FromBody] EmploymentVerificationRequest request)
        {
            if (!ModelState.IsValid || request == null)
            {
                return BadRequest("Invalid data.");
            }
            else
            {
                var responseMessage = _verifyEmploymentService.VerifyEmployment(request);
                return Ok(responseMessage);
            }

        }
    }
}
