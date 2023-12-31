﻿using AutoMapper;
using repair_management_backend.DTOs.Accessory;
using repair_management_backend.DTOs.Category;
using repair_management_backend.DTOs.Customer;
using repair_management_backend.DTOs.CustomerProduct;
using repair_management_backend.DTOs.Manufacturer;
using repair_management_backend.DTOs.PurchasedProduct;
using repair_management_backend.DTOs.PurchaseOrder;
using repair_management_backend.DTOs.RepairAccessory;
using repair_management_backend.DTOs.RepairCustomerProduct;
using repair_management_backend.DTOs.RepairLog;
using repair_management_backend.DTOs.RepairOrder;
using repair_management_backend.DTOs.RepairProduct;
using repair_management_backend.DTOs.RepairReason;
using repair_management_backend.DTOs.RepairTask;
using repair_management_backend.DTOs.RepairType;
using repair_management_backend.DTOs.Status;
using repair_management_backend.DTOs.Task;
using repair_management_backend.DTOs.User;
using repair_management_backend.DTOs.WarrantyPolicyTask;

namespace repair_management_backend
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<PurchasedProduct, GetPurchasedProductDTO>();
            CreateMap<PurchaseOrder, GetPurchaseOrderDTO>();
            CreateMap<PurchaseOrder, GetPurchaseOrderNoCustomerDTO>();
            CreateMap<Customer, GetCustomerDTO>();
            CreateMap<AddCustomerDTO, Customer>();
            CreateMap<AddRepairOrderDTO, RepairOrder>();
            CreateMap<RepairOrder, GetRepairOrderDTO>();
            CreateMap<RepairOrder, GetRepairOrderNoCustomerDTO>();
            CreateMap<User, GetUserDTO>();
            CreateMap<Models.Task, GetTaskDTO>();
            CreateMap<RepairType, GetRepairTypeDTO>();
            CreateMap<RepairReason, GetRepairReasonDTO>();
            CreateMap<Status, GetStatusDTO>();
            CreateMap<RepairProduct, GetRepairProductDTO>();
            CreateMap<Category, GetCategoryDTO>();
            CreateMap<Manufacturer, GetManufacturerDTO>();
            CreateMap<Accessory, GetAccessoryDTO>();
            CreateMap<RepairAccessory, GetRepairAccessoryDTO>();
            CreateMap<RepairTask, GetRepairTaskDTO>();
            CreateMap<RepairCustomerProduct, GetRepairCustomerProductDTO>();
            CreateMap<CustomerProduct, GetCustomerProductDTO>();
            CreateMap<AddRepairAccessoryDTO, RepairAccessory>();
            CreateMap<UpdateRepairOrderDTO, RepairOrder>();
            CreateMap<UpdateCustomerDTO, Customer>();
            CreateMap<RepairLog, GetRepairLogDTO>();
            CreateMap<WarrantyPolicyTask, GetWarrantyPolicyTaskDTO>();
        }
    }
}
