namespace Patients.Api.DTOs
{
    public class ResponseModel<T>
    {
        public string Message { get; set; }
        public string Exception { get; set; }
        public T Data { get; set; }
    }
}
