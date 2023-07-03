using AutoMapper;
using Fooddeliveryapp1.DTO;
using Fooddeliveryapp1.Models;
using Fooddeliveryapp1.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Fooddeliveryapp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public ItemController(IItemRepository itemRepository, IMapper mapper)
        {

            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        [HttpGet("items")]
        public async Task<IActionResult> GetAllProduct()
        {
            var items = await _itemRepository.GetAllAsync();
            var itemDtos = _mapper.Map<IEnumerable<ItemDto>>(items);
            return Ok(itemDtos);
        }
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetProduct([FromRoute] int id)
        {
            var items = await _itemRepository.GetByIdAsync(id);
            if (items == null)
                return NotFound();
            var itemDtos = _mapper.Map<ItemDto>(items);
            return Ok(itemDtos);
        }
        [HttpPost]
        
        public async Task<IActionResult>AddProduct(ItemDto itemDto)
        {


            var items = _mapper.Map<Item>(itemDto);

            await _itemRepository.AddAsync(items);
            var createditemsDto = _mapper.Map<ItemDto>(items);
            return Ok(createditemsDto);
        }
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateProduct(int id, ItemDto itemDto)
        {

            var existingProduct = await _itemRepository.GetByIdAsync(id);
            if (existingProduct == null)
                return NotFound();

            _mapper.Map(itemDto, existingProduct);

            await _itemRepository.UpdateAsync(existingProduct);
            return Ok("Item updated uccessfully");
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var existingProduct = await _itemRepository.GetByIdAsync(id);
            if (existingProduct == null)
                return NotFound();

            await _itemRepository.DeleteAsync(existingProduct);
            return Ok("items deleted successfully");
        }
    }
    }


