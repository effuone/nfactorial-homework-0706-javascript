﻿using System;
using System.Collections.Generic;

namespace Dalidikes.Models
{
    public partial class Store
    {
        public Store()
        {
            Orders = new HashSet<Order>();
            Stocks = new HashSet<Stock>();
            staff = new HashSet<Staff>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; } = null!;
        #nullable enable
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        #nullable disable
        [JsonIgnore]
        public virtual ICollection<Order> Orders { get; set; }
        [JsonIgnore]

        public virtual ICollection<Stock> Stocks { get; set; }
        [JsonIgnore]

        public virtual ICollection<Staff> staff { get; set; }
    }
}
