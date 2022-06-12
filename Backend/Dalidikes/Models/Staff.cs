using System;
using System.Collections.Generic;

namespace Dalidikes.Models
{
    public partial class Staff
    {
        public Staff()
        {
            InverseManager = new HashSet<Staff>();
            Orders = new HashSet<Order>();
        }

        public int StaffId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        #nullable enable
        public string? Phone { get; set; }
        [JsonIgnore]

        public virtual Staff? Manager { get; set; }
        #nullable disable
        public byte Active { get; set; }
        public int StoreId { get; set; }
        public int? ManagerId { get; set; }


        [JsonIgnore]

        public virtual Store Store { get; set; } = null!;
        [JsonIgnore]

        public virtual ICollection<Staff> InverseManager { get; set; }
        [JsonIgnore]

        public virtual ICollection<Order> Orders { get; set; }
    }
}
