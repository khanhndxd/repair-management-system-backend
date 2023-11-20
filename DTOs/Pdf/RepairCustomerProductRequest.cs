using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.Pdf
{
    public class RepairCustomerProductRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
