using CarRental.Core.Entities;
using CarRental.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.Repository
{
    public class CarRepository:IRepository<CarEntity>
    {
        readonly DataContext _dataContext;
        public CarRepository(DataContext dataContext) 
        { _dataContext = dataContext; }

        public List<CarEntity> GetAllData()
        {
            return _dataContext.Cars;
        }

        public CarEntity GetById(int id)
        {
            return _dataContext.Cars.Find(c => c.Id == id);
        }

        public bool Add(CarEntity car)
        {
            try
            {
                _dataContext.Cars.Add(car);
                _dataContext.SaveData();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(CarEntity car)
        {
            CarEntity c = _dataContext.Cars.Find(c => c.Id == car.Id);
            if (c == null)
                return false;
            _dataContext.Cars.Remove(c);
            _dataContext.Cars.Add(car);
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
                CarEntity c=_dataContext.Cars.Find(c => c.Id==id);
                _dataContext.Cars.Remove(c);
                _dataContext.SaveData();
                return true;
            }
            catch
            { return false; }
        }

        
    }
}
