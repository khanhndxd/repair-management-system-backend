using AutoMapper;
using repair_management_backend.DTOs.Customer;
using repair_management_backend.DTOs.PurchasedProduct;
using repair_management_backend.DTOs.PurchaseOrder;

namespace repair_management_backend
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<PurchasedProduct, GetPurchasedProductDTO>();
            CreateMap<PurchaseOrder, GetPurchaseOrderDTO>();
            CreateMap<Customer, GetCustomerDTO>();
            CreateMap<AddCustomerDTO, Customer>();
        }
    }
}
