using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Dalidikes.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; } = null!;
        [JsonIgnore]

        public virtual ICollection<Product> Products { get; set; }
    }
}
