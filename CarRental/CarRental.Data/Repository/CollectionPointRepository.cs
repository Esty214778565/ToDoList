using CarRental.Core.Entities;
using CarRental.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.Repository
{
    public class CollectionPointRepository : IRepository<CollectionPointEntity>
    {
        readonly DataContext _dataContext;

        public CollectionPointRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool Add(CollectionPointEntity collectionPoint)
        {
            try
            {
                _dataContext.CollectionPoints.Add(collectionPoint);
                _dataContext.SaveData();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                CollectionPointEntity c_p = _dataContext.CollectionPoints.Find(c => c.Id == id);

                _dataContext.CollectionPoints.Remove(c_p);
                _dataContext.SaveData();
                return true;
            }
            catch
            { return false; }
        }

        public List<CollectionPointEntity> GetAllData()
        {
            return _dataContext.CollectionPoints;
        }

        public CollectionPointEntity GetById(int id)
        {
            return _dataContext.CollectionPoints.Find(c => c.Id == id);
        }

        public bool Update(CollectionPointEntity collectionPoint)
        {
            CollectionPointEntity c = _dataContext.CollectionPoints.Find(c => c.Id == collectionPoint.Id);
            if (c == null)
                return false;
            _dataContext.CollectionPoints.Remove(c);
            _dataContext.CollectionPoints.Add(collectionPoint);
            try
            {
                _dataContext.SaveData();
                return true;
            }
            catch { return false; }
        }
    }
}
