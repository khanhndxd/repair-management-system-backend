namespace repair_management_backend.DTOs.RepairOrder
{
    public class UpdateProductDTO
    {
        public int RepairOrderId { get; set; }
        public AddRepairOrderDTO RepairProducts { get; set; }
    }
}
