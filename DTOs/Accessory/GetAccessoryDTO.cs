﻿using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.Accessory
{
    public class GetAccessoryDTO
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Unit { get; set; }
        public double Price { get; set; }
    }
}
