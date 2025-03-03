namespace S2___CA2___MVC_Application.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int  Amount {  get; set; }

        public decimal Total { get; set; }


    }
}
