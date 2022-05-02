namespace ShoppingCartAPI.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }  
        public int qnt { get; set; }
    }
}
