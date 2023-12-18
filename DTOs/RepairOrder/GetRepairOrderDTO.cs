using repair_management_backend.DTOs.Customer;
using repair_management_backend.DTOs.RepairAccessory;
using repair_management_backend.DTOs.RepairCustomerProduct;
using repair_management_backend.DTOs.RepairLog;
using repair_management_backend.DTOs.RepairProduct;
using repair_management_backend.DTOs.RepairReason;
using repair_management_backend.DTOs.RepairTask;
using repair_management_backend.DTOs.RepairType;
using repair_management_backend.DTOs.Status;
using repair_management_backend.DTOs.User;
using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.RepairOrder
{
    public class GetRepairOrderDTO
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public virtual GetUserDTO CreatedBy { get; set; }
        public virtual GetUserDTO RepairedBy { get; set; }
        public virtual GetUserDTO ReceivedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ReceiveAt { get; set; }
        [MaxLength(255)]
        public string ReceiveType { get; set; }
        public double TotalPrice { get; set; }
        [MaxLength(255)]
        public string Note { get; set; }
        public GetCustomerDTO Customer { get; set; }
        public GetStatusDTO Status { get; set; }
        public GetRepairTypeDTO RepairType { get; set; }
        public GetRepairReasonDTO RepairReason { get; set; }
        public List<GetRepairLogDTO>? RepairLogs { get; set; }
        public virtual ICollection<GetRepairProductDTO> RepairProducts { get; set; }
        public virtual ICollection<GetRepairAccessoryDTO> RepairAccessories { get; set; }
        public virtual ICollection<GetRepairTaskDTO> RepairTasks { get; set; }
        public virtual ICollection<GetRepairCustomerProductDTO> RepairCustomerProducts { get; set; }
    }
}
