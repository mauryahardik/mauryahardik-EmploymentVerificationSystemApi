namespace EmploymentVerification.Dto.ResponseMessage
{
    public class ResponseMessageDto
    {
        public object? Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
