using System;
using System.Collections.Generic;

namespace Dalidikes.Models
{
    public partial class Stock
    {
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        [JsonIgnore]

        public virtual Product Product { get; set; } = null!;
        [JsonIgnore]

        public virtual Store Store { get; set; } = null!;
    }
}
