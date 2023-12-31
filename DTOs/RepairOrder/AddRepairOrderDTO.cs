﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.RepairOrder
{
    public class AddRepairOrderDTO
    {
        public int CustomerId { get; set; }
        public string CreatedById { get; set; }
        public string RepairedById { get; set; }
        public string ReceivedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ReceiveAt { get; set; }
        [MaxLength(255)]
        public string ReceiveType { get; set; }
        public double TotalPrice { get; set; }
        public int StatusId { get; set; }
        public int RepairTypeId { get; set; }
        public int RepairReasonId { get; set; }
        [MaxLength(255)]
        public string Note { get; set; }
    }
}
