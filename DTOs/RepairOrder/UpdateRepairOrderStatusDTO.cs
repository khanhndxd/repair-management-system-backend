namespace repair_management_backend.DTOs.RepairOrder
{
    public class UpdateRepairOrderStatusDTO
    {
        public int Id { get; set; }
        public string CreatedById { get; set; }
        public string RepairedById { get; set; }
        public string ReceivedById { get; set; }
        public int StatusId { get; set; }
    }
}
