using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Base { }

    public class UserMaster {
        //Create properties based on table columns	
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public int Active { get; set; }
        public string UserRole { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class Donation {
        public int DonationId { get; set; }
        public string Name { get; set; }
        public string UserEmail { get; set; }
        public int RecipientId { get; set; }
        public string Address { get; set; }
        public string DonationType { get; set; }
        public string PickUpDate { get; set; }
        public string Status { get; set; }
        public string CharityName { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class Recipient {
        public int RecipientId { get; set; }
        public string CharityName { get; set; }
        public string Email { get; set; }
        public string RegNumber { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public int Active { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class CategoryMaster {
        public int CategoryId { get; set; }
        public string CategoryType { get; set; }
        public string CreatedDate { get; set; }

    }
}
