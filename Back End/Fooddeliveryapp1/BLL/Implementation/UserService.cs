//using Fooddeliveryapp1.BLL.Interface;
//using Fooddeliveryapp1.Models;
//using Fooddeliveryapp1.Repository.Interface;

//namespace Fooddeliveryapp1.BLL.Implementation
//{
//    public class UserService : IUserService
//    {
//        private readonly IUserRepository _userRepository;

//        public UserService(IUserRepository userRepository)
//        {
//            _userRepository = userRepository;
//        }

//        public IEnumerable<User> GetAllUsers()
//        {
//            //return _userRepository.GetAllUsers();
//            var users = _userRepository.GetAllUsers();

//            return users;
//        }

//        public IEnumerable<User> GetUserById(int userid)
//        {
//            return _userRepository.GetUserById(userid);
//        }


//    }
//}