namespace repair_management_backend.DTOs.RepairOrder
{
    public class RepairOrderFullDTO
    {
        public int CustomerId { get; set; }
        public string CreatedById { get; set; }
        public string RepairedById { get; set; }
        public string ReceivedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ReceiveAt { get; set; }
        public string ReceiveType { get; set; }
        public double TotalPrice { get; set; }
        public int StatusId { get; set; }
        public int RepairTypeId { get; set; }
        public int RepairReasonId { get; set; }
        public int TaskId { get; set; }
        public string Note { get; set; }
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }
    }
}
