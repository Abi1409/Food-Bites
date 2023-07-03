using AutoMapper;
using Fooddeliveryapp1.DTO;
using Fooddeliveryapp1.Models;
using Fooddeliveryapp1.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Fooddeliveryapp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;

        public CartController(ICartRepository cartRepository , IMapper mapper)
        {
            _cartRepository = cartRepository;
              _mapper = mapper;
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {


            var orders = await _cartRepository.GetAllAsync();
            var orderDtos = _mapper.Map<IEnumerable<CartDto>>(orders);
            return Ok(orderDtos);


        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var orders = await _cartRepository.GetByIdAsync(id);
            if (orders == null)
                return NotFound();
            var cartDtos = _mapper.Map<CartDto>(orders);
            return Ok(cartDtos);
        }
        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateOrder(CartDto cartDto)
        {


            var orders = _mapper.Map<Cart>(cartDto);

            await _cartRepository.AddAsync(orders);
            var createdOrderDto = _mapper.Map<CartDto>(orders);
            return Ok(createdOrderDto);
        }
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateOrder(int id, CartDto cartDto)
        {

            var existingOrder = await _cartRepository.GetByIdAsync(id);
            if (existingOrder == null)
                return NotFound();

            _mapper.Map(cartDto, existingOrder);

            await _cartRepository.UpdateAsync(existingOrder);
            return NoContent();
        }
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var existingOrder = await _cartRepository.GetByIdAsync(id);
            if (existingOrder == null)
                return NotFound();

            await _cartRepository.DeleteAsync(existingOrder);
            return Ok("Order deleted sauccessfully");
        }
    }
}
