namespace repair_management_backend.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public Boolean Success { get; set; } = true;
        public String Message { get; set; } = String.Empty;
    }
}
