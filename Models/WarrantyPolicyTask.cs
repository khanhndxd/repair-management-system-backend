namespace repair_management_backend.Models
{
    public class WarrantyPolicyTask
    {
        public int Id { get; set; }
        public int WarrantyPolicyId { get; set; }
        public int TaskId { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public WarrantyPolicy WarrantyPolicy { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Task Task { get; set; }
    }
}
