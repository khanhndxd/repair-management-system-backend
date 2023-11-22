namespace repair_management_backend.DTOs.Pdf
{
    public class PdfGenerationRequest
    {
        public int RepairOrderId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ReceiveAt { get; set; }
        public string RepairReason { get; set; }
        public List<AccessoryRequest> Accessories { get; set; }
        public List<RepairProductsRequest> RepairProducts { get; set; }
        public List<TaskRequest> RepairTasks { get; set; }
        public List<RepairCustomerProductRequest> RepairCustomerProducts { get; set; }
        public double TotalPrice { get; set; }
    }
}
