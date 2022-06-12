using System;
using System.Collections.Generic;

namespace Dalidikes.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        #nullable enable
        public string? Phone { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        #nullable disable
        [JsonIgnore]


        public virtual ICollection<Order> Orders { get; set; }
    }
}
