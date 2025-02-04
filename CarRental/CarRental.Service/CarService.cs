using CarRental.Core.Entities;
using CarRental.Core.IRepository;
using CarRental.Core.IService;

namespace CarRental.Service
{
    public class CarService : ICarService
    {

       
        readonly IRepository<CarEntity> _CarRepository;
        public CarService()
        {

        }
        public CarService(IRepository<CarEntity> carRepository)
        {
            _CarRepository = carRepository;
        }

        public List<CarEntity> GetCarList()
        {
            return _CarRepository.GetAllData();
        }

        public CarEntity GetCarById(int id)
        {
            return _CarRepository.GetById(id);
        }

        public bool Add(CarEntity Car)
        {
            return _CarRepository.Add(Car);
        }

        public bool Update(CarEntity Car)
        {
            return _CarRepository.Update(Car);
        }

        public bool Delete(int id)
        {
            return _CarRepository.Delete(id);
        }

    }

}
