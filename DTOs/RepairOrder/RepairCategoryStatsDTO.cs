namespace repair_management_backend.DTOs.RepairOrder
{
    public class RepairCategoryStatsDTO
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<RepairTypeStatsDTO> RepairTypeStats { get; set; }
    }
}
