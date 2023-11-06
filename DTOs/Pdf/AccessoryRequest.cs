namespace repair_management_backend.DTOs.Pdf
{
    public class AccessoryRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
