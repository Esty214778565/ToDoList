using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Entities
{
    public enum METHOD_OF_PAYMENT { credit, cash, check }
    public class InvitationEntity
    {
        public InvitationEntity()
        {
        }

        public int Id { get; set; }
        public int NumInvitation { get; set; }
        public int UserTz { get; set; }
        public int CarId { get; set; }
        public DateTime CollectionDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int CollectionPointId { get; set; }
        public DateTime DateOfOrder { get; set; }
        public METHOD_OF_PAYMENT Method_payment { get; set; }
        public decimal TotalPayment { get; set; }

        public InvitationEntity(int id, int numInvitation, int userTz, int carId, DateTime collectionDate, DateTime returnDate, int collectionPointId, DateTime dateOfOrder, METHOD_OF_PAYMENT method_payment, decimal totalPayment)
        {
            Id = id;
            NumInvitation = numInvitation;
            UserTz = userTz;
            CarId = carId;
            CollectionDate = collectionDate;
            ReturnDate = returnDate;
            CollectionPointId = collectionPointId;
            DateOfOrder = dateOfOrder;
            Method_payment = method_payment;
            TotalPayment = totalPayment;
        }
    }
}
