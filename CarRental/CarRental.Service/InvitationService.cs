﻿using CarRental.Core.Entities;
using CarRental.Core.IRepository;
using CarRental.Core.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Service
{
    public class InvitationService : IInvitationService
    {

       
        readonly IRepository<InvitationEntity> _InvitationRepository;
 public InvitationService()
        {

        }

        public InvitationService(IRepository<InvitationEntity> invitationRepository)
        {
            _InvitationRepository = invitationRepository;
        }

        public List<InvitationEntity> GetInvitationList()
        {
            return _InvitationRepository.GetAllData();
        }

        public InvitationEntity GetInvitationById(int id)
        {
            return _InvitationRepository.GetById(id);
        }

        public bool Add(InvitationEntity Invitation)
        {
            return _InvitationRepository.Add(Invitation);
        }

        public bool Update(InvitationEntity Invitation)
        {
            return _InvitationRepository.Update(Invitation);
        }

        public bool Delete(int id)
        {
            return _InvitationRepository.Delete(id);
        }

    }

}
