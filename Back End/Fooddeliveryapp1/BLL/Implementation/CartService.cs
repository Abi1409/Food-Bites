//using Fooddeliveryapp1.BLL.Interface;
//using Fooddeliveryapp1.Models;
//using Fooddeliveryapp1.Repository.Implementation;

//namespace Fooddeliveryapp1.BLL.Implementation
//{
//    public class CartService : ICartService
//    {
//        private readonly CartRepository _cartRepository;

//        public CartService(CartRepository cartRepository)
//        {
//            _cartRepository = cartRepository;
//        }
//        public List<Cart> GetAllCarts()
//        {
//            var cart = _cartRepository.GetAllCarts();
//            return cart;
//        }
//        public Cart GetCartById(int id)
//        {
//            return _cartRepository.GetCartById(id);
//        }

//    }
//}
