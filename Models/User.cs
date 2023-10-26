using Microsoft.AspNetCore.Identity;

namespace repair_management_backend.Models
{
    public class User : IdentityUser
    {
        public virtual ICollection<RepairOrder> CreatedOrders { get; set; }
        public virtual ICollection<RepairOrder> RepairedOrders { get; set; }
    }
}
