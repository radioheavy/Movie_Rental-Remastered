using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class AppUserProfile : BaseEntity
    {
        public string Adress { get; set; }
        public int CreditCardNo { get; set; }
        public byte CVV { get; set; }
        public byte? ExpiryDay { get; set; }
        public byte ExpiryMount { get; set; }
        public short ExpiryYear { get; set; }
        public string PhoneNo { get; set; }
        public string SubscriptionType { get; set; }

        //relational properties

        public virtual AppUser AppUser { get; set; }
    }
}