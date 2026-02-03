using eCommerce.Model.Responses;

namespace eCommerce.Model.Responses
{
    public class CartItemResponse
    {
        public ProductResponse Product { get; set; } = null!;
        public int Count { get; set; }
    }
}

