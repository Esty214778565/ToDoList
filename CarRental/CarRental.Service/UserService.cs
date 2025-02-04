using CarRental.Core.Entities;
using CarRental.Core.IRepository;
using CarRental.Core.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Service
{
    public class UserService : IUserService
    {
       
        public UserService()
        {
                
        }
        readonly IRepository<UserEntity> _userRepository;

        public UserService(IRepository<UserEntity> userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserEntity> GetUserList()
        {
            return _userRepository.GetAllData();
        }

        public UserEntity GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public bool Add(UserEntity user)
        {//I add...
            var res=_userRepository.GetById(user.Id);
            if(res != null) 
                return false;
           return _userRepository.Add(user);
        }

        public bool Update(UserEntity user)
        {
            return _userRepository.Update(user);
        }

        public bool Delete(int id)
        {
           return _userRepository.Delete(id);
        }
       
    }
}
