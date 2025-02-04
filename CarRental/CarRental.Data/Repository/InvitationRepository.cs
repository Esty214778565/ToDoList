using CarRental.Core.Entities;
using CarRental.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.Repository
{
    public class InvitationRepository : IRepository<InvitationEntity>
    {
        readonly DataContext _dataContext;
        public InvitationRepository(DataContext dataContext)
        { _dataContext = dataContext; }

        public List<InvitationEntity> GetAllData()
        {
            return _dataContext.Invitations;
        }

        public InvitationEntity GetById(int id)
        {
            return _dataContext.Invitations.Find(c => c.Id == id);
        }

        public bool Add(InvitationEntity Invitation)
        {
            try
            {
                _dataContext.Invitations.Add(Invitation);
                _dataContext.SaveData();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(InvitationEntity Invitation)
        {
            InvitationEntity c = _dataContext.Invitations.Find(c => c.Id == Invitation.Id);
            if (c == null)
                return false;
            _dataContext.Invitations.Remove(c);
            _dataContext.Invitations.Add(Invitation);
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
                InvitationEntity i = _dataContext.Invitations.Find(c => c.Id == id);

                _dataContext.Invitations.Remove(i);
                _dataContext.SaveData();
                return true;
            }
            catch
            { return false; }
        }


    }

}
