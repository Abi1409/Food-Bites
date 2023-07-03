//using Fooddeliveryapp1.BLL.Interface;
//using Fooddeliveryapp1.DTO;
//using Fooddeliveryapp1.Models;
//using Fooddeliveryapp1.Repository.Interface;
//using AutoMapper;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

//namespace Fooddeliveryapp1.BLL.Implementation
//{
//    public class ItemService : IItemService
//    {
//        private readonly IItemRepository _itemRepository;
       

//        public ItemService(IItemRepository itemRepository)
//        {
//            _itemRepository = itemRepository;
//        }

//        public Item GetItemById(int itemId)
//        {
//            return _itemRepository.GetItemById(itemId);
//        }

//        public List<Item> GetAllItems()
//        {
//            var items = _itemRepository.GetAllItems();
            
//            return items;
//        }

//        //public void AddItem(Item item)
//        //{
//        //    _itemRepository.AddItem(item);
//        //}
//        public Response<List<ItemDto>> AddItem(List<ItemDto> item)
//        {
//            Response<List<ItemDto>> response = new Response<List<ItemDto>>();
//            var addeditem = _itemRepository.AddItem(item);
//            // bool isUpdated = _itemRepository.UpdateItem(item);
//            if(addeditem!=null)
//            {
//                response.Data = addeditem;
//                response.Succeeded = true;
//                response.Message = "Added Successfully";
//            }
//            else
//            {
//                response.Succeeded = false;
//                response.Message = "Added failed";
//            }

//            return response;
//        }

//        public bool UpdateItem(List<ItemDto> item)
//        {
//            var updateditem = _itemRepository.UpdateItem(item);
//           // bool isUpdated = _itemRepository.UpdateItem(item);

//            return updateditem;
//        }

//        public bool DeleteItem(int itemId)
//        {
//            var deleteditem = _itemRepository.DeleteItem(itemId);
//            return deleteditem;
//        }
//    }
//}
