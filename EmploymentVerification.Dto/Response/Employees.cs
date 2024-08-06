using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentVerification.Dto.Response
{
    public class Employees
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string VerificationCode { get; set; }
    }
}
