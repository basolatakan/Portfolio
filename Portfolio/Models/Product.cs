namespace Portfolio.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Year { get; set; }

        public Product(int id, string productName, int quantity, string year)
        {
            Id = id;
            ProductName = productName;
            Quantity = quantity;
            Year = year;
        }

    }
}
