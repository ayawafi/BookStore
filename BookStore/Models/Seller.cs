namespace BookStore.Models
{
    public class Seller
    {
        public int Id { get; set; }            
        public string Name { get; set; }      
        public string ContactInfo { get; set; } 

        public List<Order> Orders { get; set; }
    }
}
