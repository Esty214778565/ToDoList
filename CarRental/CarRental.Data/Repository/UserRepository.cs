using CarRental.Core.Entities;
using CarRental.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.Repository
{
    public class UserRepository:IRepository<UserEntity>
    {
        readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<UserEntity> GetAllData()
        {
            return _dataContext.Users;
        }

        public UserEntity GetById(int id)
        {
           return _dataContext.Users.Find(u=>u.Id == id);
        }

        public bool Add(UserEntity user)
        {
            try
            {
                _dataContext.Users.Add(user);
                _dataContext.SaveData();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(UserEntity user)
        {
          UserEntity u=  _dataContext.Users.Find(u=>u.Id== user.Id);
            if (u==null)
                return false;
            _dataContext.Users.Remove(u);
            _dataContext.Users.Add(user);
            try
            {
                _dataContext.SaveData();
                return true;
            }
            catch { return false; }

        }

        public bool Delete(int id)
        {
            try
            {
              UserEntity u = _dataContext.Users.Find(c => c.Id==id);
               
                _dataContext.Users.Remove(u);
              _dataContext.SaveData();
                return true;
            }
            catch
            { return false; }
        }

       

      

        
    }
}
