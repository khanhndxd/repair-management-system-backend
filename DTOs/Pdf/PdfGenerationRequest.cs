namespace repair_management_backend.DTOs.Pdf
{
    public class PdfGenerationRequest
    {
        public int repairOrderId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ReceiveAt { get; set; }
        public List<AccessoryRequest> Accessories { get; set; }
        public List<RepairProductsRequest> RepairProducts { get; set; }
        public TaskRequest Tasks { get; set; }
    }
}
