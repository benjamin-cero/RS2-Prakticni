using System.Collections.Generic;

namespace eCommerce.Model.Responses
{
    public class CartResponse
    {
        public List<CartItemResponse> Items { get; set; } = new List<CartItemResponse>();
    }
}

