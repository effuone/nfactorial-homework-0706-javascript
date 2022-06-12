namespace Dalidikes.ViewModels
{
    public class ProductVm
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public short ModelYear {get; set;}
        public decimal Price {get; set;}
    }
    public class CreateProductVm
    {
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public DateTime ModelYear { get; set; }
        public decimal Price {get; set;}
    }
}